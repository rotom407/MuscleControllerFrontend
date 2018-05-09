using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using ZeroMQ;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;

namespace MuscleControllerFrontend {
    public partial class FrmMain : Form {
        private const string MMapPath = ".\\mmap.txt";

        public FrmMain() {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        //when the form is loaded
        private void FrmMain_Load(object sender, EventArgs e) {
            Globals.sthread.Start();    //start the serial worker thread
            Globals.ithread.Start();    //start the interop thread
            UpdateSerialState(Serialstate.Closed);    //set the serial state to closed
            UpdateCursorXYZbaseTextbox();
            for (int i = 0; i < 3; i++) {   //set the cutoff freqs of filters
                Globals.chfilters[i] = new Filters(Config.filttrend[0], Config.filtdenoise[0], Config.filttilt[0], Config.filtcutoff[0]);
                Globals.filters[i] = new Filters(Config.filttrend[0], Config.filtdenoise[0], Config.filttilt[0], Config.filtcutoff[0]);
            }
            for (int i = 0; i < 4; i++) {   //set the cutoff freqs of filters
                Globals.schmitt[i] = new SchmittTrigger(Config.schmitthigh[0], Config.schmittlow[0]);
                Globals.chschmitt[i] = new SchmittTrigger(Config.schmitthigh[0], Config.schmittlow[0]);
            }
            for (int i = 0; i < 4; i++) {   //set the cutoff freqs of filters
                Globals.emgfilter[i] = new LowpassFilterCutoffHighpass(Config.filtemg[0], Config.filtemgcutoff[0]);
                Globals.chemgfilter[i] = new LowpassFilterCutoffHighpass(Config.filtemg[0], Config.filtemgcutoff[0]);
            }
            //set Y ranges of charts
            Cht1.ChartAreas[0].Axes[1].Maximum = 3000;
            Cht1.ChartAreas[0].Axes[1].Minimum = -3000;
            Cht2.ChartAreas[0].Axes[1].Maximum = 10000;
            Cht2.ChartAreas[0].Axes[1].Minimum = -10000;
            Cht3.ChartAreas[0].Axes[1].Maximum = 500;
            Cht3.ChartAreas[0].Axes[1].Minimum = -500;

            CmbMode.SelectedIndex = 0;

            //File.Create(MMapPath);
            //MemoryMappedFile.CreateFromFile(MMapPath);

        }

        //when the form is closed
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Globals.sworker.Kill(); //kill the serial worker thread
            Globals.iworker.Kill(); //kill the interop worker thread
        }

        //when Open button is clicked
        private void BtnOpen_Click(object sender, EventArgs e) {
            try {
                Globals.sworker.SetPortOpened(true, TxtPort.Text);  //tell the serial worker to open the serial port
                BtnOpen.Enabled = false;
                tmrStart.Enabled = true;    //wait for some time before doing something next
            } catch {
                MessageBox.Show("Error opening serial port.");
                UpdateSerialState(Serialstate.Closed);
            }
        }

        private void TmrStart_Tick(object sender, EventArgs e) {
            UpdateSerialState(Serialstate.Single);  //enable the buttons
            tmrStart.Enabled = false;
        }

        //update serial state and enable/disable the buttons
        private void UpdateSerialState(Serialstate state) {
            Globals.state = state;
            switch (state) {
                case Serialstate.Closed:
                    BtnClose.Enabled = false;
                    BtnOpen.Enabled = true;
                    BtnTrig.Enabled = false;
                    BtnStart.Enabled = false;
                    BtnStop.Enabled = false;
                    GrpCursor.Enabled = true;
                    break;
                case Serialstate.Single:
                    BtnClose.Enabled = true;
                    BtnOpen.Enabled = false;
                    BtnTrig.Enabled = true;
                    BtnStart.Enabled = true;
                    BtnStop.Enabled = false;
                    GrpCursor.Enabled = true;
                    break;
                case Serialstate.Continuous:
                    BtnClose.Enabled = false;
                    BtnOpen.Enabled = false;
                    BtnTrig.Enabled = false;
                    BtnStart.Enabled = false;
                    BtnStop.Enabled = true;
                    GrpCursor.Enabled = true;
                    break;
            }
        }

        //when close button is clicked
        private void BtnClose_Click(object sender, EventArgs e) {
            try {
                Globals.sworker.SetPortOpened(false, "");   //close the serial port
                UpdateSerialState(Serialstate.Closed);
            } catch {
                MessageBox.Show("Error closing serial port.");
            }
        }

        //when trigger button is clicked
        private void BtnTrig_Click(object sender, EventArgs e) {
            try {
                Globals.sworker.SetCount(1);    //set trigger count to 1
                Thread.Sleep(50);   //wait data to be received
                lock (Globals.dbuf.buf) {
                    string str = "";
                    for (int i = 0; i < 10; i++) {
                        str += (Globals.dbuf.buf.First().Data[i]) + " ";
                    }
                    Globals.dbuf.buf.Clear();
                    TxtTest.Text = str; //display the result
                }
                lock (Globals.dbuf.chbuf) {
                    Globals.dbuf.chbuf.Clear();
                }
            } catch {
                MessageBox.Show("Error writing serial port.");
            }
        }

        //when start button is clicked
        private void BtnStart_Click(object sender, EventArgs e) {
            if (Globals.state != Serialstate.Closed) {
                Globals.sworker.SetCount(-1);   //set serial worker status to continuous
                tmrUpdateChart.Enabled = true;
                tmrUpdateCursor.Enabled = true;
                UpdateSerialState(Serialstate.Continuous);
            }
        }

        //when stop button is clicked
        private void BtnStop_Click(object sender, EventArgs e) {
            if (Globals.state != Serialstate.Closed) {
                Globals.sworker.SetCount(0);    //stop the serial worker
                tmrUpdateChart.Enabled = false;
                tmrUpdateCursor.Enabled = false;
                UpdateSerialState(Serialstate.Single);
            }
        }

        //when update chart timer is triggered
        private void TmrUpdateChart_Tick(object sender, EventArgs e) {
            lock (Globals.dbuf.chbuf) { //lock the data buffer when accessing it to prevent bad things
                foreach (var dat in Globals.dbuf.chbuf) {   //read all data records in the buffer
                    foreach (var name in new string[] { "AcX", "AcY", "AcZ" }) {
                        int index = name == "AcX" ? 0 : (name == "AcY" ? 1 : 2);
                        Globals.chfilters[index].Feed(dat.Data[index]);
                        Cht1.Series[name].Points.SuspendUpdates();
                        Cht1.Series[name].Points.Add(Globals.chfilters[index].Smooth);  //add points to charts
                        if (Cht1.Series[name].Points.Count > 60)
                            Cht1.Series[name].Points.RemoveAt(0);   //if a chart has more than 60 points, remove the first point
                        Cht1.Series[name].Points.ResumeUpdates();
                    }
                    foreach (var name in new string[] { "GyX", "GyY", "GyZ" }) {
                        int index = name == "GyX" ? 3 : (name == "GyY" ? 4 : 5);
                        Cht2.Series[name].Points.SuspendUpdates();
                        Cht2.Series[name].Points.Add(dat.Data[index]);
                        if (Cht2.Series[name].Points.Count > 60)
                            Cht2.Series[name].Points.RemoveAt(0);
                        Cht2.Series[name].Points.ResumeUpdates();
                    }
                    foreach (var name in new string[] { "Ch1", "Ch2", "Ch3", "Ch4" }) {
                        int index = name == "Ch1" ? 6 : (name == "Ch2" ? 7 : (name == "Ch3" ? 8 : 9));
                        Globals.chschmitt[index - 6].Feed(dat.Data[index]);
                        if (name == "Ch4") {
                            Globals.chemgfilter[index - 6].Feed(dat.Data[7]-dat.Data[6]);
                        } else {
                            Globals.chemgfilter[index - 6].Feed(dat.Data[index]);
                        }
                        Cht3.Series[name].Points.SuspendUpdates();
                        Cht3.Series[name].Points.Add(Globals.chemgfilter[index-6].output);
                        if (Cht3.Series[name].Points.Count > 60)
                            Cht3.Series[name].Points.RemoveAt(0);
                        Cht3.Series[name].Points.ResumeUpdates();
                    }
                }
                Globals.dbuf.chbuf.Clear(); //clear the buffer
            }
        }

        //when update cursor timer is triggered
        private void TmrUpdateCursor_Tick(object sender, EventArgs e) {
            var chnclick = new List<SchmittTrigger.TriggerType>[4];
            for (int i = 0; i < 4; i++) {
                chnclick[i] = new List<SchmittTrigger.TriggerType>();
                chnclick[i].Clear();
            }
            lock (Globals.dbuf.buf) { //lock the data buffer when accessing it to prevent bad things
                short[] lastdat = new short[10];
                for (int i = 0; i < 10; i++) {
                    lastdat[i] = Globals.lastrec.Data[i];
                }
                foreach (var dat in Globals.dbuf.buf) { //read all data records in the buffer
                    if (dat.Success) {  //if the data record is marked with 'success'
                        foreach (var name in new string[] { "AcX", "AcY", "AcZ" }) {
                            int index = name == "AcX" ? 0 : (name == "AcY" ? 1 : 2);
                            Globals.filters[index].Feed(dat.Data[index]);   //feed the filters with AcX AcY AcZ
                        }
                        for (int i = 6; i < 10; i++) {

                            if (i == 9) {
                                Globals.emgfilter[i - 6].Feed(dat.Data[7] - dat.Data[6]);
                            } else {
                                Globals.emgfilter[i - 6].Feed(dat.Data[i]);
                            }

                            SchmittTrigger.TriggerType r;
                            r = Globals.schmitt[i - 6].Feed((int)Globals.emgfilter[i - 6].output);
                            switch (r) {
                                case SchmittTrigger.TriggerType.Rising:
                                    chnclick[i - 6].Add(r);
                                    break;
                                case SchmittTrigger.TriggerType.Falling:
                                    chnclick[i - 6].Add(r);
                                    break;
                            }
                        }
                        for (int i = 0; i < 3; i++) {
                            lastdat[i] = (short)Globals.filters[i].Smooth;  //get the output of filters
                        }
                        for (int i = 3; i < 10; i++) {
                            lastdat[i] = dat.Data[i];   //store other data (GyX, GyY, ...)
                        }
                    }
                }
                for (int i = 0; i < 10; i++) {
                    Globals.lastrec.Data[i] = lastdat[i];
                }
                Globals.dbuf.buf.Clear();   //clear the buffer
            }
            //calculate XY speeds from accelerometer data
            Vector3D nowvec = new Vector3D(Globals.lastrec.Data[0], Globals.lastrec.Data[1], Globals.lastrec.Data[2]);
            nowvec *= Globals.cursordat.Speed;
            Vector3D decompvec = nowvec.Decompose(Globals.cursordat.Xbase, Globals.cursordat.Ybase, Globals.cursordat.Zbase);
            double tempxsp = decompvec.X, tempysp = decompvec.Y;
            //double tempxsp = -Globals.lastrec.data[5] * Globals.cursordat.speed/3, tempysp = -Globals.lastrec.data[4] * Globals.cursordat.speed/3;
            double norm = Math.Sqrt(tempxsp * tempxsp + tempysp * tempysp);
            double deadzone = 2.5;
            //apply deadzone
            if (norm > deadzone) {
                tempxsp *= Math.Pow((norm - deadzone) / 1.5, 1.3) / norm;
                tempysp *= Math.Pow((norm - deadzone) / 1.5, 1.3) / norm;
            } else {
                tempysp = tempxsp = 0.0;
            }


            switch (Globals.mainMode) {
                case MainMode.MMouse:
                    //update XY speeds and record the difference
                    Globals.cursordat.Xsp = tempxsp;
                    Globals.cursordat.Ysp = tempysp;
                    double origx = Globals.cursordat.X, origy = Globals.cursordat.Y;
                    Globals.cursordat.UpdateXY();
                    double nowx = Globals.cursordat.X, nowy = Globals.cursordat.Y;
                    /*
                    Globals.cursordat.X = 400 + 20*tempxsp;
                    Globals.cursordat.Y = 300 + 20*tempysp;*/
                    //truncate the floating point numbers into integers, recording the remaining fractional parts
                    int outx, outy;
                    outx = (int)Math.Truncate(nowx - origx + Globals.cursordat.Xremaining);
                    outy = (int)Math.Truncate(nowy - origy + Globals.cursordat.Yremaining);
                    UpdateCursorXYSpeedTextbox(decompvec.X, decompvec.Y, outx, outy);
                    Globals.cursordat.Xremaining = nowx - origx + Globals.cursordat.Xremaining - outx;
                    Globals.cursordat.Yremaining = nowy - origy + Globals.cursordat.Yremaining - outy;
                    UpdateSimChart();   //update cursor simulation chart
                    foreach (var i in chnclick[0]) {
                        //if (i == SchmittTrigger.TriggerType.Rising);
                        if (i == SchmittTrigger.TriggerType.Falling)
                            ChtSim.Series["LClick"].Points.AddXY(Globals.cursordat.X, Globals.cursordat.Y);
                    }
                    foreach (var i in chnclick[1]) {
                        //if (i == SchmittTrigger.TriggerType.Rising);
                        if (i == SchmittTrigger.TriggerType.Falling)
                            ChtSim.Series["RClick"].Points.AddXY(Globals.cursordat.X, Globals.cursordat.Y);
                    }
                    if (Globals.cursordat.Active) {
                        MoveCursor(outx, outy); //call Windows API to move the cursor if enabled
                                                /*foreach(var i in chnclick[0]) {
                                                    if (i == SchmittTrigger.TriggerType.Rising)
                                                        DoMouseClick(MOUSEEVENTF_LEFTDOWN);
                                                    if (i == SchmittTrigger.TriggerType.Falling)
                                                        DoMouseClick(MOUSEEVENTF_LEFTUP);
                                                }*/
                        foreach (var i in chnclick[2]) {
                            if (i == SchmittTrigger.TriggerType.Rising)
                                DoMouseClick(MOUSEEVENTF_LEFTDOWN);
                            if (i == SchmittTrigger.TriggerType.Falling)
                                DoMouseClick(MOUSEEVENTF_LEFTUP);
                        }
                    }
                    break;
                case MainMode.GEDemo:
                    ChtSim.Series["Cursor"].Points[0].XValue = 400 + 10 * tempxsp;
                    ChtSim.Series["Cursor"].Points[0].YValues[0] = 300 + 10 * tempysp;
                    if (Globals.cursordat.Active) {
                        if (tempxsp > Config.gedemodeadzone) {
                            switch (Globals.gedemoxstate) {
                                case 0:
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                                    break;
                                case -1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                                    break;
                            }
                            Globals.gedemoxstate = 1;
                        } else if (tempxsp < -Config.gedemodeadzone) {
                            switch (Globals.gedemoxstate) {
                                case 0:
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                                    break;
                                case 1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                                    break;
                            }
                            Globals.gedemoxstate = -1;
                        } else {
                            switch (Globals.gedemoxstate) {
                                case -1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                                    break;
                                case 1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                                    break;
                            }
                            Globals.gedemoxstate = 0;
                        }

                        if (tempysp > Config.gedemodeadzone) {
                            switch (Globals.gedemoystate) {
                                case 0:
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.UP);
                                    break;
                                case -1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.UP);
                                    break;
                            }
                            Globals.gedemoystate = 1;
                        } else if (tempysp < -Config.gedemodeadzone) {
                            switch (Globals.gedemoystate) {
                                case 0:
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.DOWN);
                                    break;
                                case 1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.UP);
                                    Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.DOWN);
                                    break;
                            }
                            Globals.gedemoystate = -1;
                        } else {
                            switch (Globals.gedemoystate) {
                                case -1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                                    break;
                                case 1:
                                    Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.UP);
                                    break;
                            }
                            Globals.gedemoystate = 0;
                        }

                        int origpotential=Globals.gedemozoompotential;
                        if (Globals.emgfilter[3].output > Config.gedemozoomup) {
                            Globals.gedemozoompotential += Config.gedemozoomstrength;
                        }
                        if (Globals.emgfilter[3].output < Config.gedemozoomdown) {
                            Globals.gedemozoompotential -= Config.gedemozoomstrength;
                        }
                        if (origpotential == 0) {
                            if (Globals.gedemozoompotential > 0) {
                                Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.PRIOR);
                            }
                            if (Globals.gedemozoompotential < 0) {
                                Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.NEXT);
                            }
                        }else if (origpotential < 0) {
                            if (Globals.gedemozoompotential == 0) {
                                Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.NEXT);
                            }
                            if (Globals.gedemozoompotential > 0) {
                                Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.NEXT);
                                Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.PRIOR);
                            }
                        } else if (origpotential > 0) {
                            if (Globals.gedemozoompotential == 0) {
                                Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.PRIOR);
                            }
                            if (Globals.gedemozoompotential < 0) {
                                Globals.inputSim.Keyboard.KeyUp(VirtualKeyCode.PRIOR);
                                Globals.inputSim.Keyboard.KeyDown(VirtualKeyCode.NEXT);
                            }
                        }
                        if (Globals.gedemozoompotential > 0)
                            Globals.gedemozoompotential--;
                        if (Globals.gedemozoompotential < 0)
                            Globals.gedemozoompotential++;
                    }
                    break;
            }

        }

        private void Resetbases(MainMode mode) {
            switch (mode) {
                case MainMode.MMouse:
                    Globals.cursordat.Xbase = Config.defaultbase[0, 0];
                    Globals.cursordat.Ybase = Config.defaultbase[0, 1];
                    Globals.cursordat.Zbase = Config.defaultbase[0, 2];
                    break;
                case MainMode.GEDemo:
                    Globals.cursordat.Xbase = Config.defaultbase[1, 0];
                    Globals.cursordat.Ybase = Config.defaultbase[1, 1];
                    Globals.cursordat.Zbase = Config.defaultbase[1, 2];
                    break;
            }
            UpdateCursorXYZbaseTextbox();
        }

        //when reset button is clicked
        private void BtnXYReset_Click(object sender, EventArgs e) {
            //reset the XYZ bases
            Resetbases(Globals.mainMode);
        }

        //call Windows API to move the cursor
        private void MoveCursor(int dx, int dy) {
            Cursor = new System.Windows.Forms.Cursor(System.Windows.Forms.Cursor.Current.Handle);
            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + dx, System.Windows.Forms.Cursor.Position.Y + dy);
        }

        public void DoMouseClick(uint action) {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(action, X, Y, 0, 0);
        }

        private void UpdateCursorXYZbaseTextbox() {
            TxtXYBasis.Text = "Xbase = " + Globals.cursordat.Xbase.ToString() + "\r\nYbase = " + Globals.cursordat.Ybase.ToString() + "\r\nZbase = " + Globals.cursordat.Zbase.ToString();
        }

        private void UpdateCursorXYSpeedTextbox(double xsp, double ysp, int outx, int outy) {
            TxtXYNow.Text = string.Format("Xsp = {0:+0.00;-0.00} Ysp = {1:+0.00;-0.00} dX = {2} dY = {3}", xsp, ysp, outx, outy);
        }

        private void UpdateSimChart() {
            ChtSim.Series["Cursor"].Points[0].XValue = Globals.cursordat.X;
            ChtSim.Series["Cursor"].Points[0].YValues[0] = Globals.cursordat.Y;
        }

        //when setxbase button is clicked
        private void BtnSetX_Click(object sender, EventArgs e) {
            //calculate x base and z base (Zbase=Xbase x Ybase)
            Globals.cursordat.Xbase.X = Globals.lastrec.Data[0];
            Globals.cursordat.Xbase.Y = Globals.lastrec.Data[1];
            Globals.cursordat.Xbase.Z = Globals.lastrec.Data[2];
            Globals.cursordat.Xbase.Normalize();
            Globals.cursordat.Zbase=Globals.cursordat.Xbase.Cross(Globals.cursordat.Ybase);
            UpdateCursorXYZbaseTextbox();
        }

        //when setxbase button is clicked
        private void BtnSetY_Click(object sender, EventArgs e) {
            //calculate y base and z base (Zbase=Xbase x Ybase)
            Globals.cursordat.Ybase.X = Globals.lastrec.Data[0];
            Globals.cursordat.Ybase.Y = Globals.lastrec.Data[1];
            Globals.cursordat.Ybase.Z = Globals.lastrec.Data[2];
            Globals.cursordat.Ybase.Normalize();
            Globals.cursordat.Zbase=Globals.cursordat.Xbase.Cross(Globals.cursordat.Ybase);
            UpdateCursorXYZbaseTextbox(); 
        }

        //when apply checkbox is changed
        private void ChkApply_CheckedChanged(object sender, EventArgs e) {
            Globals.cursordat.Active = ChkApply.Checked;    //update the status of cursor movement enabled setting
        }

        private void BtnTestInterop_Click(object sender, EventArgs e) {
            Console.WriteLine("Hello");
            MessageBox.Show(Console.Read().ToString());
        }

        private void CmbChn_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                TxtStHi.Text = Globals.schmitt[CmbChn.SelectedIndex].up.ToString();
                TxtStLo.Text = Globals.schmitt[CmbChn.SelectedIndex].down.ToString();
            } catch {

            }
        }

        private void TxtStHi_TextChanged(object sender, EventArgs e) {
            try {
                if (TxtStHi.Text != "") {
                    Globals.schmitt[CmbChn.SelectedIndex].up = Convert.ToInt32(TxtStHi.Text);
                    Globals.chschmitt[CmbChn.SelectedIndex].up = Convert.ToInt32(TxtStHi.Text);
                }
            } catch {

            }
        }

        private void TxtStLo_TextChanged(object sender, EventArgs e) {
            try {
                if (TxtStLo.Text != "") {
                    Globals.schmitt[CmbChn.SelectedIndex].down = Convert.ToInt32(TxtStLo.Text);
                    Globals.chschmitt[CmbChn.SelectedIndex].down = Convert.ToInt32(TxtStLo.Text);
                }
            } catch {

            }
        }

        private void CmbMode_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (var filt in Globals.filters) {
                filt.Reset = true;
                filt.Trend.alpha = Config.filttrend[CmbMode.SelectedIndex];
                filt.Denoise.alpha = Config.filtdenoise[CmbMode.SelectedIndex];
                filt.Tilt.alpha = Config.filttilt[CmbMode.SelectedIndex];
                filt.Tilt.cutoff = Config.filtcutoff[CmbMode.SelectedIndex];
            }
            foreach (var filt in Globals.chfilters) {
                filt.Reset = true;
                filt.Trend.alpha = Config.filttrend[CmbMode.SelectedIndex];
                filt.Denoise.alpha = Config.filtdenoise[CmbMode.SelectedIndex];
                filt.Tilt.alpha = Config.filttilt[CmbMode.SelectedIndex];
                filt.Tilt.cutoff = Config.filtcutoff[CmbMode.SelectedIndex];
            }
            foreach (var filt in Globals.emgfilter) {
                filt.alpha = Config.filtemg[CmbMode.SelectedIndex];
                filt.cutoff = Config.filtemgcutoff[CmbMode.SelectedIndex];
            }
            foreach (var filt in Globals.chemgfilter) {
                filt.alpha = Config.filtemg[CmbMode.SelectedIndex];
                filt.cutoff = Config.filtemgcutoff[CmbMode.SelectedIndex];
            }
            foreach (var trigger in Globals.schmitt) {
                trigger.up = Config.schmitthigh[CmbMode.SelectedIndex];
                trigger.down = Config.schmittlow[CmbMode.SelectedIndex];
            }
            foreach (var trigger in Globals.chschmitt) {
                trigger.up = Config.schmitthigh[CmbMode.SelectedIndex];
                trigger.down = Config.schmittlow[CmbMode.SelectedIndex];
            }
            switch (CmbMode.SelectedIndex) {
                case 0:
                    Globals.mainMode = MainMode.MMouse;
                    break;
                case 1:
                    Globals.mainMode = MainMode.GEDemo;
                    break;
            }
            Resetbases(Globals.mainMode);
        }
    }
}

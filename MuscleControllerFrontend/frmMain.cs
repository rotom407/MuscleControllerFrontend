using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace MuscleControllerFrontend {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            Globals.sthread.Start();
            Updatestate(Serialstate.Closed);
            UpdatecursorXYZ();
            for (int i = 0; i < 3; i++) {
                Globals.chfilters[i] = new Filters(0.995, 0.5, 0.7, 1000);
                Globals.filters[i] = new Filters(0.995, 0.5, 0.7, 1000);
            }
            cht1.ChartAreas[0].Axes[1].Maximum = 3000;
            cht1.ChartAreas[0].Axes[1].Minimum = -3000;
            cht2.ChartAreas[0].Axes[1].Maximum = 10000;
            cht2.ChartAreas[0].Axes[1].Minimum = -10000;
            cht3.ChartAreas[0].Axes[1].Maximum = 1000;
            cht3.ChartAreas[0].Axes[1].Minimum = 0;
        }

        private void btnOpen_Click(object sender, EventArgs e) {
            try {
                Globals.sworker.SetRunning(true, txtPort.Text);
                btnOpen.Enabled = false;
                tmrStart.Enabled = true;
            } catch {
                MessageBox.Show("Error opening serial port.");
                Updatestate(Serialstate.Closed);
            }
        }

        private void Updatestate(Serialstate state) {
            Globals.state = state;
            switch (state) {
                case Serialstate.Closed:
                    btnClose.Enabled = false;
                    btnOpen.Enabled = true;
                    btnTrig.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = false;
                    grpCursor.Enabled = false;
                    break;
                case Serialstate.Single:
                    btnClose.Enabled = true;
                    btnOpen.Enabled = false;
                    btnTrig.Enabled = true;
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    grpCursor.Enabled = false;
                    break;
                case Serialstate.Continuous:
                    btnClose.Enabled = false;
                    btnOpen.Enabled = false;
                    btnTrig.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    grpCursor.Enabled = true;
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            try {
                Globals.sworker.SetRunning(false, "");
                Updatestate(Serialstate.Closed);
            } catch {
                MessageBox.Show("Error closing serial port.");
            }
        }

        private void btnTrig_Click(object sender, EventArgs e) {
            try {
                Globals.sworker.SetCount(1);
                Thread.Sleep(50);
                lock (Globals.dbuf.buf) {
                    string str = "";
                    for (int i = 0; i < 10; i++) {
                        str += (Globals.dbuf.buf.First().data[i]) + " ";
                    }
                    Globals.dbuf.buf.Clear();
                    txtTest.Text = str;
                }
                lock (Globals.dbuf.chbuf) {
                    Globals.dbuf.chbuf.Clear();
                }
            } catch {
                MessageBox.Show("Error writing serial port.");
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (Globals.state != Serialstate.Closed) {
                Globals.sworker.SetCount(-1);
                tmrUpdateChart.Enabled = true;
                tmrUpdateCursor.Enabled = true;
                Updatestate(Serialstate.Continuous);
            }
        }

        private void tmrStart_Tick(object sender, EventArgs e) {
            Updatestate(Serialstate.Single);
            tmrStart.Enabled = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Globals.sworker.Kill();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            if (Globals.state != Serialstate.Closed) {
                Globals.sworker.SetCount(0);
                tmrUpdateChart.Enabled = false;
                tmrUpdateCursor.Enabled = false;
                Updatestate(Serialstate.Single);
            }
        }

        private void tmrUpdateChart_Tick(object sender, EventArgs e) {
            lock (Globals.dbuf.chbuf) {
                foreach (var dat in Globals.dbuf.chbuf) {
                    foreach (var name in new string[] { "AcX", "AcY", "AcZ" }) {
                        int index = name == "AcX" ? 0 : (name == "AcY" ? 1 : 2);
                        Globals.chfilters[index].Feed(dat.data[index]);
                        cht1.Series[name].Points.SuspendUpdates();
                        cht1.Series[name].Points.Add(Globals.chfilters[index].Smooth);
                        //cht1.Series[name].Points.Add(Globals.filters[index].denoise.output);
                        if (cht1.Series[name].Points.Count > 60)
                            cht1.Series[name].Points.RemoveAt(0);
                        cht1.Series[name].Points.ResumeUpdates();
                    }
                    foreach (var name in new string[] { "GyX", "GyY", "GyZ" }) {
                        int index = name == "GyX" ? 3 : (name == "GyY" ? 4 : 5);
                        cht2.Series[name].Points.SuspendUpdates();
                        cht2.Series[name].Points.Add(dat.data[index]);
                        if (cht2.Series[name].Points.Count > 60)
                            cht2.Series[name].Points.RemoveAt(0);
                        cht2.Series[name].Points.ResumeUpdates();
                    }
                    foreach (var name in new string[] { "Ch1", "Ch2", "Ch3", "Ch4" }) {
                        int index = name == "Ch1" ? 6 : (name == "Ch2" ? 7 : (name == "Ch3" ? 8 : 9));
                        cht3.Series[name].Points.SuspendUpdates();
                        cht3.Series[name].Points.Add(dat.data[index]);
                        if (cht3.Series[name].Points.Count > 60)
                            cht3.Series[name].Points.RemoveAt(0);
                        cht3.Series[name].Points.ResumeUpdates();
                    }
                }
                Globals.dbuf.chbuf.Clear();
            }
        }

        private void tmrUpdateCursor_Tick(object sender, EventArgs e) {
            lock (Globals.dbuf.buf) {
                short[] lastdat = new short[10];
                for (int i = 0; i < 10; i++) {
                    lastdat[i] = Globals.lastrec.data[i];
                }
                foreach (var dat in Globals.dbuf.buf) {
                    if (dat.success) {
                        foreach (var name in new string[] { "AcX", "AcY", "AcZ" }) {
                            int index = name == "AcX" ? 0 : (name == "AcY" ? 1 : 2);
                            Globals.filters[index].Feed(dat.data[index]);
                        }
                        for (int i = 0; i < 3; i++) {
                            lastdat[i] = (short)Globals.filters[i].Smooth;
                        }
                        for (int i = 3; i < 10; i++) {
                            lastdat[i] = dat.data[i];
                        }
                    }
                }
                for (int i = 0; i < 10; i++) {
                    Globals.lastrec.data[i] = lastdat[i];
                }
                Globals.dbuf.buf.Clear();
            }
            Vector3D nowvec = new Vector3D(Globals.lastrec.data[0], Globals.lastrec.data[1], Globals.lastrec.data[2]);
            nowvec.Scale(Globals.cursordat.Speed);
            Vector3D decompvec = nowvec.Decompose(Globals.cursordat.Xbase, Globals.cursordat.Ybase, Globals.cursordat.Zbase);
            double tempxsp = decompvec.x, tempysp = decompvec.y;
            //double tempxsp = -Globals.lastrec.data[5] * Globals.cursordat.speed/3, tempysp = -Globals.lastrec.data[4] * Globals.cursordat.speed/3;
            double mode = Math.Sqrt(tempxsp * tempxsp + tempysp * tempysp);
            double deadzone = 2.5;
            if (mode > deadzone) {
                tempxsp *= Math.Pow((mode - deadzone) / 1.5, 1.3) / mode;
                tempysp *= Math.Pow((mode - deadzone) / 1.5, 1.3) / mode;
            } else {
                tempysp = tempxsp = 0.0;
            }
            Globals.cursordat.Xsp = tempxsp;
            Globals.cursordat.Ysp = tempysp;
            double origx = Globals.cursordat.X, origy = Globals.cursordat.Y;
            Globals.cursordat.UpdateXY();
            /*
            Globals.cursordat.X = 400 + 20*tempxsp;
            Globals.cursordat.Y = 300 + 20*tempysp;*/
            double nowx = Globals.cursordat.X, nowy = Globals.cursordat.Y;
            int outx, outy;
            outx = (int)Math.Truncate(nowx - origx + Globals.cursordat.Xremaining);
            outy = (int)Math.Truncate(nowy - origy + Globals.cursordat.Yremaining);
            UpdateXYspeed(decompvec.x, decompvec.y, outx, outy);
            Globals.cursordat.Xremaining = nowx - origx + Globals.cursordat.Xremaining - outx;
            Globals.cursordat.Yremaining = nowy - origy + Globals.cursordat.Yremaining - outy;

            UpdateSimChart();
            if (Globals.cursordat.Active)
                MoveCursor(outx, outy);
        }

        private void btnXYReset_Click(object sender, EventArgs e) {
            Globals.cursordat.Xbase.x = 0.0;
            Globals.cursordat.Xbase.y = -1.0;
            Globals.cursordat.Xbase.z = 0.0;
            Globals.cursordat.Ybase.x = 0.0;
            Globals.cursordat.Ybase.y = 0.0;
            Globals.cursordat.Ybase.z = 1.0;
            Globals.cursordat.Zbase.x = -1.0;
            Globals.cursordat.Zbase.y = 0.0;
            Globals.cursordat.Zbase.z = 0.0;
            UpdatecursorXYZ();
        }

        private void MoveCursor(int dx, int dy) {
            Cursor = new System.Windows.Forms.Cursor(System.Windows.Forms.Cursor.Current.Handle);
            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + dx, System.Windows.Forms.Cursor.Position.Y + dy);
        }

        private void UpdatecursorXYZ() {
            txtXYBasis.Text = "Xbase = " + Globals.cursordat.Xbase.ToString() + "\r\nYbase = " + Globals.cursordat.Ybase.ToString() + "\r\nZbase = " + Globals.cursordat.Zbase.ToString();
        }

        private void UpdateXYspeed(double xsp, double ysp, int outx, int outy) {
            txtXYNow.Text = string.Format("Xsp = {0:+0.00;-0.00} Ysp = {1:+0.00;-0.00} dX = {2} dY = {3}", xsp, ysp, outx, outy);
        }

        private void UpdateSimChart() {
            chtSim.Series["Cursor"].Points[0].XValue = Globals.cursordat.X;
            chtSim.Series["Cursor"].Points[0].YValues[0] = Globals.cursordat.Y;
        }

        private void btnSetX_Click(object sender, EventArgs e) {
            Globals.cursordat.Xbase.x = Globals.lastrec.data[0];
            Globals.cursordat.Xbase.y = Globals.lastrec.data[1];
            Globals.cursordat.Xbase.z = Globals.lastrec.data[2];
            Globals.cursordat.Xbase.Normalize();
            Globals.cursordat.Zbase.Assign(Globals.cursordat.Xbase.Cross(Globals.cursordat.Ybase));
            UpdatecursorXYZ();
        }

        private void btnSetY_Click(object sender, EventArgs e) {
            Globals.cursordat.Ybase.x = Globals.lastrec.data[0];
            Globals.cursordat.Ybase.y = Globals.lastrec.data[1];
            Globals.cursordat.Ybase.z = Globals.lastrec.data[2];
            Globals.cursordat.Ybase.Normalize();
            Globals.cursordat.Zbase.Assign(Globals.cursordat.Xbase.Cross(Globals.cursordat.Ybase));
            UpdatecursorXYZ();
        }

        private void txtXYBasis_TextChanged(object sender, EventArgs e) {

        }

        private void chkApply_CheckedChanged(object sender, EventArgs e) {
            Globals.cursordat.Active = chkApply.Checked;
        }
    }
}

namespace MuscleControllerFrontend
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(400D, 300D);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnTrig = new System.Windows.Forms.Button();
            this.TxtTest = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.tmrStart = new System.Windows.Forms.Timer(this.components);
            this.Cht1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnStop = new System.Windows.Forms.Button();
            this.tmrUpdateChart = new System.Windows.Forms.Timer(this.components);
            this.Cht2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GrpCursor = new System.Windows.Forms.GroupBox();
            this.TxtStLo = new System.Windows.Forms.TextBox();
            this.TxtStHi = new System.Windows.Forms.TextBox();
            this.CmbChn = new System.Windows.Forms.ComboBox();
            this.ChtSim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TxtXYNow = new System.Windows.Forms.TextBox();
            this.TxtXYBasis = new System.Windows.Forms.TextBox();
            this.BtnXYReset = new System.Windows.Forms.Button();
            this.BtnSetY = new System.Windows.Forms.Button();
            this.BtnSetX = new System.Windows.Forms.Button();
            this.ChkApply = new System.Windows.Forms.CheckBox();
            this.tmrUpdateCursor = new System.Windows.Forms.Timer(this.components);
            this.Cht3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnTestInterop = new System.Windows.Forms.Button();
            this.CmbMode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cht1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht2)).BeginInit();
            this.GrpCursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtSim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(12, 14);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(44, 21);
            this.TxtPort.TabIndex = 0;
            this.TxtPort.Text = "COM11";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(62, 14);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Open";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Enabled = false;
            this.BtnClose.Location = new System.Drawing.Point(143, 14);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnTrig
            // 
            this.BtnTrig.Enabled = false;
            this.BtnTrig.Location = new System.Drawing.Point(224, 14);
            this.BtnTrig.Name = "BtnTrig";
            this.BtnTrig.Size = new System.Drawing.Size(75, 23);
            this.BtnTrig.TabIndex = 3;
            this.BtnTrig.Text = "Trigger";
            this.BtnTrig.UseVisualStyleBackColor = true;
            this.BtnTrig.Click += new System.EventHandler(this.BtnTrig_Click);
            // 
            // TxtTest
            // 
            this.TxtTest.Location = new System.Drawing.Point(12, 41);
            this.TxtTest.Name = "TxtTest";
            this.TxtTest.Size = new System.Drawing.Size(287, 21);
            this.TxtTest.TabIndex = 4;
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Location = new System.Drawing.Point(12, 69);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrStart
            // 
            this.tmrStart.Interval = 500;
            this.tmrStart.Tick += new System.EventHandler(this.TmrStart_Tick);
            // 
            // Cht1
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea1.AxisY.Maximum = 30000D;
            chartArea1.AxisY.Minimum = -30000D;
            chartArea1.Name = "ChartArea1";
            this.Cht1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.Cht1.Legends.Add(legend1);
            this.Cht1.Location = new System.Drawing.Point(12, 98);
            this.Cht1.Name = "Cht1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Firebrick;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Legend = "Legend1";
            series1.Name = "AcX";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.LimeGreen;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "AcY";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.RoyalBlue;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "AcZ";
            this.Cht1.Series.Add(series1);
            this.Cht1.Series.Add(series2);
            this.Cht1.Series.Add(series3);
            this.Cht1.Size = new System.Drawing.Size(287, 91);
            this.Cht1.TabIndex = 6;
            this.Cht1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Accelerometer";
            this.Cht1.Titles.Add(title1);
            // 
            // BtnStop
            // 
            this.BtnStop.Enabled = false;
            this.BtnStop.Location = new System.Drawing.Point(93, 69);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 7;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // tmrUpdateChart
            // 
            this.tmrUpdateChart.Interval = 30;
            this.tmrUpdateChart.Tick += new System.EventHandler(this.TmrUpdateChart_Tick);
            // 
            // Cht2
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea2.AxisY.Maximum = 30000D;
            chartArea2.AxisY.Minimum = -30000D;
            chartArea2.Name = "ChartArea1";
            this.Cht2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.Cht2.Legends.Add(legend2);
            this.Cht2.Location = new System.Drawing.Point(12, 195);
            this.Cht2.Name = "Cht2";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Firebrick;
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series4.Legend = "Legend1";
            series4.Name = "GyX";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.LimeGreen;
            series5.IsVisibleInLegend = false;
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "GyY";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.RoyalBlue;
            series6.IsVisibleInLegend = false;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "GyZ";
            this.Cht2.Series.Add(series4);
            this.Cht2.Series.Add(series5);
            this.Cht2.Series.Add(series6);
            this.Cht2.Size = new System.Drawing.Size(287, 91);
            this.Cht2.TabIndex = 9;
            this.Cht2.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Gyroscope (not used)";
            this.Cht2.Titles.Add(title2);
            this.Cht2.Visible = false;
            // 
            // GrpCursor
            // 
            this.GrpCursor.Controls.Add(this.TxtStLo);
            this.GrpCursor.Controls.Add(this.TxtStHi);
            this.GrpCursor.Controls.Add(this.CmbChn);
            this.GrpCursor.Controls.Add(this.ChtSim);
            this.GrpCursor.Controls.Add(this.TxtXYNow);
            this.GrpCursor.Controls.Add(this.TxtXYBasis);
            this.GrpCursor.Controls.Add(this.BtnXYReset);
            this.GrpCursor.Controls.Add(this.BtnSetY);
            this.GrpCursor.Controls.Add(this.BtnSetX);
            this.GrpCursor.Enabled = false;
            this.GrpCursor.Location = new System.Drawing.Point(315, 14);
            this.GrpCursor.Name = "GrpCursor";
            this.GrpCursor.Size = new System.Drawing.Size(251, 339);
            this.GrpCursor.TabIndex = 11;
            this.GrpCursor.TabStop = false;
            this.GrpCursor.Text = "Cursor Movement";
            // 
            // TxtStLo
            // 
            this.TxtStLo.Location = new System.Drawing.Point(88, 127);
            this.TxtStLo.Name = "TxtStLo";
            this.TxtStLo.Size = new System.Drawing.Size(75, 21);
            this.TxtStLo.TabIndex = 22;
            this.TxtStLo.TextChanged += new System.EventHandler(this.TxtStLo_TextChanged);
            // 
            // TxtStHi
            // 
            this.TxtStHi.Location = new System.Drawing.Point(6, 127);
            this.TxtStHi.Name = "TxtStHi";
            this.TxtStHi.Size = new System.Drawing.Size(75, 21);
            this.TxtStHi.TabIndex = 21;
            this.TxtStHi.TextChanged += new System.EventHandler(this.TxtStHi_TextChanged);
            // 
            // CmbChn
            // 
            this.CmbChn.FormattingEnabled = true;
            this.CmbChn.Items.AddRange(new object[] {
            "Ch1",
            "Ch2",
            "Ch3",
            "Ch4"});
            this.CmbChn.Location = new System.Drawing.Point(170, 127);
            this.CmbChn.Name = "CmbChn";
            this.CmbChn.Size = new System.Drawing.Size(75, 20);
            this.CmbChn.TabIndex = 20;
            this.CmbChn.SelectedIndexChanged += new System.EventHandler(this.CmbChn_SelectedIndexChanged);
            // 
            // ChtSim
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.Maximum = 800D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.IsReversed = true;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Maximum = 600D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.ChtSim.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.ChtSim.Legends.Add(legend3);
            this.ChtSim.Location = new System.Drawing.Point(6, 153);
            this.ChtSim.Name = "ChtSim";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "Legend1";
            series7.MarkerColor = System.Drawing.Color.Red;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Cursor";
            series7.Points.Add(dataPoint1);
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.MarkerColor = System.Drawing.Color.Gold;
            series8.MarkerSize = 10;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series8.Name = "LClick";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.MarkerColor = System.Drawing.Color.MediumTurquoise;
            series9.MarkerSize = 10;
            series9.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series9.Name = "RClick";
            this.ChtSim.Series.Add(series7);
            this.ChtSim.Series.Add(series8);
            this.ChtSim.Series.Add(series9);
            this.ChtSim.Size = new System.Drawing.Size(239, 171);
            this.ChtSim.TabIndex = 18;
            this.ChtSim.Text = "]";
            // 
            // TxtXYNow
            // 
            this.TxtXYNow.Location = new System.Drawing.Point(6, 100);
            this.TxtXYNow.Name = "TxtXYNow";
            this.TxtXYNow.Size = new System.Drawing.Size(239, 21);
            this.TxtXYNow.TabIndex = 17;
            // 
            // TxtXYBasis
            // 
            this.TxtXYBasis.Location = new System.Drawing.Point(6, 49);
            this.TxtXYBasis.Multiline = true;
            this.TxtXYBasis.Name = "TxtXYBasis";
            this.TxtXYBasis.Size = new System.Drawing.Size(239, 45);
            this.TxtXYBasis.TabIndex = 16;
            // 
            // BtnXYReset
            // 
            this.BtnXYReset.Location = new System.Drawing.Point(170, 20);
            this.BtnXYReset.Name = "BtnXYReset";
            this.BtnXYReset.Size = new System.Drawing.Size(75, 23);
            this.BtnXYReset.TabIndex = 14;
            this.BtnXYReset.Text = "Reset";
            this.BtnXYReset.UseVisualStyleBackColor = true;
            this.BtnXYReset.Click += new System.EventHandler(this.BtnXYReset_Click);
            // 
            // BtnSetY
            // 
            this.BtnSetY.Location = new System.Drawing.Point(88, 20);
            this.BtnSetY.Name = "BtnSetY";
            this.BtnSetY.Size = new System.Drawing.Size(75, 23);
            this.BtnSetY.TabIndex = 13;
            this.BtnSetY.Text = "Set Ybase";
            this.BtnSetY.UseVisualStyleBackColor = true;
            this.BtnSetY.Click += new System.EventHandler(this.BtnSetY_Click);
            // 
            // BtnSetX
            // 
            this.BtnSetX.Location = new System.Drawing.Point(6, 20);
            this.BtnSetX.Name = "BtnSetX";
            this.BtnSetX.Size = new System.Drawing.Size(75, 23);
            this.BtnSetX.TabIndex = 12;
            this.BtnSetX.Text = "Set Xbase";
            this.BtnSetX.UseVisualStyleBackColor = true;
            this.BtnSetX.Click += new System.EventHandler(this.BtnSetX_Click);
            // 
            // ChkApply
            // 
            this.ChkApply.AutoSize = true;
            this.ChkApply.Location = new System.Drawing.Point(315, 367);
            this.ChkApply.Name = "ChkApply";
            this.ChkApply.Size = new System.Drawing.Size(54, 16);
            this.ChkApply.TabIndex = 19;
            this.ChkApply.Text = "Apply";
            this.ChkApply.UseVisualStyleBackColor = true;
            this.ChkApply.CheckedChanged += new System.EventHandler(this.ChkApply_CheckedChanged);
            // 
            // tmrUpdateCursor
            // 
            this.tmrUpdateCursor.Interval = 20;
            this.tmrUpdateCursor.Tick += new System.EventHandler(this.TmrUpdateCursor_Tick);
            // 
            // Cht3
            // 
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea4.AxisY.Maximum = 30000D;
            chartArea4.AxisY.Minimum = -30000D;
            chartArea4.Name = "ChartArea1";
            this.Cht3.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.Cht3.Legends.Add(legend4);
            this.Cht3.Location = new System.Drawing.Point(12, 195);
            this.Cht3.Name = "Cht3";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Color = System.Drawing.Color.DodgerBlue;
            series10.IsVisibleInLegend = false;
            series10.IsXValueIndexed = true;
            series10.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series10.Legend = "Legend1";
            series10.Name = "Ch1";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series10.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.Gold;
            series11.IsVisibleInLegend = false;
            series11.IsXValueIndexed = true;
            series11.Legend = "Legend1";
            series11.Name = "Ch2";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Color = System.Drawing.Color.SpringGreen;
            series12.IsVisibleInLegend = false;
            series12.IsXValueIndexed = true;
            series12.Legend = "Legend1";
            series12.Name = "Ch3";
            series13.BorderWidth = 0;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Color = System.Drawing.Color.OrangeRed;
            series13.IsVisibleInLegend = false;
            series13.IsXValueIndexed = true;
            series13.Legend = "Legend1";
            series13.Name = "Ch4";
            this.Cht3.Series.Add(series10);
            this.Cht3.Series.Add(series11);
            this.Cht3.Series.Add(series12);
            this.Cht3.Series.Add(series13);
            this.Cht3.Size = new System.Drawing.Size(287, 188);
            this.Cht3.TabIndex = 12;
            title3.Name = "Title1";
            title3.Text = "EMG Envelope";
            this.Cht3.Titles.Add(title3);
            // 
            // BtnTestInterop
            // 
            this.BtnTestInterop.Location = new System.Drawing.Point(12, 389);
            this.BtnTestInterop.Name = "BtnTestInterop";
            this.BtnTestInterop.Size = new System.Drawing.Size(75, 23);
            this.BtnTestInterop.TabIndex = 13;
            this.BtnTestInterop.Text = "Hello";
            this.BtnTestInterop.UseVisualStyleBackColor = true;
            this.BtnTestInterop.Visible = false;
            this.BtnTestInterop.Click += new System.EventHandler(this.BtnTestInterop_Click);
            // 
            // CmbMode
            // 
            this.CmbMode.FormattingEnabled = true;
            this.CmbMode.Items.AddRange(new object[] {
            "Muscle Mouse",
            "Google Earth Demo"});
            this.CmbMode.Location = new System.Drawing.Point(375, 365);
            this.CmbMode.Name = "CmbMode";
            this.CmbMode.Size = new System.Drawing.Size(191, 20);
            this.CmbMode.TabIndex = 20;
            this.CmbMode.SelectedIndexChanged += new System.EventHandler(this.CmbMode_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 399);
            this.Controls.Add(this.CmbMode);
            this.Controls.Add(this.BtnTestInterop);
            this.Controls.Add(this.Cht3);
            this.Controls.Add(this.GrpCursor);
            this.Controls.Add(this.ChkApply);
            this.Controls.Add(this.Cht2);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.Cht1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.TxtTest);
            this.Controls.Add(this.BtnTrig);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.TxtPort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "MuscleControllerFrontend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cht1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht2)).EndInit();
            this.GrpCursor.ResumeLayout(false);
            this.GrpCursor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtSim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cht3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnTrig;
        private System.Windows.Forms.TextBox TxtTest;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer tmrStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Timer tmrUpdateChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht2;
        private System.Windows.Forms.GroupBox GrpCursor;
        private System.Windows.Forms.Button BtnSetX;
        private System.Windows.Forms.Button BtnXYReset;
        private System.Windows.Forms.Button BtnSetY;
        private System.Windows.Forms.TextBox TxtXYNow;
        private System.Windows.Forms.TextBox TxtXYBasis;
        private System.Windows.Forms.Timer tmrUpdateCursor;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtSim;
        private System.Windows.Forms.DataVisualization.Charting.Chart Cht3;
        private System.Windows.Forms.CheckBox ChkApply;
        private System.Windows.Forms.Button BtnTestInterop;
        private System.Windows.Forms.TextBox TxtStLo;
        private System.Windows.Forms.TextBox TxtStHi;
        private System.Windows.Forms.ComboBox CmbChn;
        private System.Windows.Forms.ComboBox CmbMode;
    }
}


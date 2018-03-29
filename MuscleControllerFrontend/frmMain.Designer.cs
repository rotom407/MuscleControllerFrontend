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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(400D, 300D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.ChkApply = new System.Windows.Forms.CheckBox();
            this.ChtSim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TxtXYNow = new System.Windows.Forms.TextBox();
            this.TxtXYBasis = new System.Windows.Forms.TextBox();
            this.BtnXYReset = new System.Windows.Forms.Button();
            this.BtnSetY = new System.Windows.Forms.Button();
            this.BtnSetX = new System.Windows.Forms.Button();
            this.tmrUpdateCursor = new System.Windows.Forms.Timer(this.components);
            this.Cht3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnTestInterop = new System.Windows.Forms.Button();
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
            chartArea13.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea13.AxisX.IsLabelAutoFit = false;
            chartArea13.AxisX.LabelStyle.Enabled = false;
            chartArea13.AxisY.IsLabelAutoFit = false;
            chartArea13.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea13.AxisY.Maximum = 30000D;
            chartArea13.AxisY.Minimum = -30000D;
            chartArea13.Name = "ChartArea1";
            this.Cht1.ChartAreas.Add(chartArea13);
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.Cht1.Legends.Add(legend13);
            this.Cht1.Location = new System.Drawing.Point(12, 98);
            this.Cht1.Name = "Cht1";
            series34.BorderWidth = 2;
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series34.Color = System.Drawing.Color.Firebrick;
            series34.IsVisibleInLegend = false;
            series34.IsXValueIndexed = true;
            series34.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series34.Legend = "Legend1";
            series34.Name = "AcX";
            series34.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series34.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series35.BorderWidth = 2;
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series35.Color = System.Drawing.Color.LimeGreen;
            series35.IsVisibleInLegend = false;
            series35.IsXValueIndexed = true;
            series35.Legend = "Legend1";
            series35.Name = "AcY";
            series36.BorderWidth = 2;
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series36.Color = System.Drawing.Color.RoyalBlue;
            series36.IsVisibleInLegend = false;
            series36.IsXValueIndexed = true;
            series36.Legend = "Legend1";
            series36.Name = "AcZ";
            this.Cht1.Series.Add(series34);
            this.Cht1.Series.Add(series35);
            this.Cht1.Series.Add(series36);
            this.Cht1.Size = new System.Drawing.Size(287, 91);
            this.Cht1.TabIndex = 6;
            this.Cht1.Text = "chart1";
            title10.Name = "Title1";
            title10.Text = "Accelerometer";
            this.Cht1.Titles.Add(title10);
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
            chartArea14.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea14.AxisX.IsLabelAutoFit = false;
            chartArea14.AxisX.LabelStyle.Enabled = false;
            chartArea14.AxisY.IsLabelAutoFit = false;
            chartArea14.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea14.AxisY.Maximum = 30000D;
            chartArea14.AxisY.Minimum = -30000D;
            chartArea14.Name = "ChartArea1";
            this.Cht2.ChartAreas.Add(chartArea14);
            legend14.Enabled = false;
            legend14.Name = "Legend1";
            this.Cht2.Legends.Add(legend14);
            this.Cht2.Location = new System.Drawing.Point(12, 195);
            this.Cht2.Name = "Cht2";
            series37.BorderWidth = 2;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series37.Color = System.Drawing.Color.Firebrick;
            series37.IsVisibleInLegend = false;
            series37.IsXValueIndexed = true;
            series37.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series37.Legend = "Legend1";
            series37.Name = "GyX";
            series37.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series37.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series38.BorderWidth = 2;
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series38.Color = System.Drawing.Color.LimeGreen;
            series38.IsVisibleInLegend = false;
            series38.IsXValueIndexed = true;
            series38.Legend = "Legend1";
            series38.Name = "GyY";
            series39.BorderWidth = 2;
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series39.Color = System.Drawing.Color.RoyalBlue;
            series39.IsVisibleInLegend = false;
            series39.IsXValueIndexed = true;
            series39.Legend = "Legend1";
            series39.Name = "GyZ";
            this.Cht2.Series.Add(series37);
            this.Cht2.Series.Add(series38);
            this.Cht2.Series.Add(series39);
            this.Cht2.Size = new System.Drawing.Size(287, 91);
            this.Cht2.TabIndex = 9;
            this.Cht2.Text = "chart1";
            title11.Name = "Title1";
            title11.Text = "Gyroscope (not used)";
            this.Cht2.Titles.Add(title11);
            // 
            // GrpCursor
            // 
            this.GrpCursor.Controls.Add(this.ChkApply);
            this.GrpCursor.Controls.Add(this.ChtSim);
            this.GrpCursor.Controls.Add(this.TxtXYNow);
            this.GrpCursor.Controls.Add(this.TxtXYBasis);
            this.GrpCursor.Controls.Add(this.BtnXYReset);
            this.GrpCursor.Controls.Add(this.BtnSetY);
            this.GrpCursor.Controls.Add(this.BtnSetX);
            this.GrpCursor.Enabled = false;
            this.GrpCursor.Location = new System.Drawing.Point(315, 14);
            this.GrpCursor.Name = "GrpCursor";
            this.GrpCursor.Size = new System.Drawing.Size(251, 330);
            this.GrpCursor.TabIndex = 11;
            this.GrpCursor.TabStop = false;
            this.GrpCursor.Text = "Cursor Movement";
            // 
            // ChkApply
            // 
            this.ChkApply.AutoSize = true;
            this.ChkApply.Location = new System.Drawing.Point(7, 305);
            this.ChkApply.Name = "ChkApply";
            this.ChkApply.Size = new System.Drawing.Size(54, 16);
            this.ChkApply.TabIndex = 19;
            this.ChkApply.Text = "Apply";
            this.ChkApply.UseVisualStyleBackColor = true;
            this.ChkApply.CheckedChanged += new System.EventHandler(this.ChkApply_CheckedChanged);
            // 
            // ChtSim
            // 
            chartArea15.AxisX.IsLabelAutoFit = false;
            chartArea15.AxisX.IsStartedFromZero = false;
            chartArea15.AxisX.MajorGrid.Enabled = false;
            chartArea15.AxisX.MajorTickMark.Enabled = false;
            chartArea15.AxisX.Maximum = 800D;
            chartArea15.AxisX.Minimum = 0D;
            chartArea15.AxisY.IsLabelAutoFit = false;
            chartArea15.AxisY.IsReversed = true;
            chartArea15.AxisY.IsStartedFromZero = false;
            chartArea15.AxisY.MajorGrid.Enabled = false;
            chartArea15.AxisY.MajorTickMark.Enabled = false;
            chartArea15.AxisY.Maximum = 600D;
            chartArea15.AxisY.Minimum = 0D;
            chartArea15.BorderColor = System.Drawing.Color.Transparent;
            chartArea15.Name = "ChartArea1";
            this.ChtSim.ChartAreas.Add(chartArea15);
            legend15.Enabled = false;
            legend15.Name = "Legend1";
            this.ChtSim.Legends.Add(legend15);
            this.ChtSim.Location = new System.Drawing.Point(6, 127);
            this.ChtSim.Name = "ChtSim";
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series40.Legend = "Legend1";
            series40.MarkerColor = System.Drawing.Color.Red;
            series40.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series40.Name = "Cursor";
            series40.Points.Add(dataPoint4);
            this.ChtSim.Series.Add(series40);
            this.ChtSim.Size = new System.Drawing.Size(239, 171);
            this.ChtSim.TabIndex = 18;
            this.ChtSim.Text = "chart1";
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
            // tmrUpdateCursor
            // 
            this.tmrUpdateCursor.Interval = 10;
            this.tmrUpdateCursor.Tick += new System.EventHandler(this.TmrUpdateCursor_Tick);
            // 
            // Cht3
            // 
            chartArea16.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea16.AxisX.IsLabelAutoFit = false;
            chartArea16.AxisX.LabelStyle.Enabled = false;
            chartArea16.AxisY.IsLabelAutoFit = false;
            chartArea16.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            chartArea16.AxisY.Maximum = 30000D;
            chartArea16.AxisY.Minimum = -30000D;
            chartArea16.Name = "ChartArea1";
            this.Cht3.ChartAreas.Add(chartArea16);
            legend16.Enabled = false;
            legend16.Name = "Legend1";
            this.Cht3.Legends.Add(legend16);
            this.Cht3.Location = new System.Drawing.Point(12, 292);
            this.Cht3.Name = "Cht3";
            series41.BorderWidth = 2;
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series41.Color = System.Drawing.Color.DodgerBlue;
            series41.IsVisibleInLegend = false;
            series41.IsXValueIndexed = true;
            series41.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series41.Legend = "Legend1";
            series41.Name = "Ch1";
            series41.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series41.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series42.BorderWidth = 2;
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series42.Color = System.Drawing.Color.Gold;
            series42.IsVisibleInLegend = false;
            series42.IsXValueIndexed = true;
            series42.Legend = "Legend1";
            series42.Name = "Ch2";
            series43.BorderWidth = 2;
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series43.Color = System.Drawing.Color.SpringGreen;
            series43.IsVisibleInLegend = false;
            series43.IsXValueIndexed = true;
            series43.Legend = "Legend1";
            series43.Name = "Ch3";
            series44.BorderWidth = 2;
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series44.Color = System.Drawing.Color.OrangeRed;
            series44.IsVisibleInLegend = false;
            series44.IsXValueIndexed = true;
            series44.Legend = "Legend1";
            series44.Name = "Ch4";
            this.Cht3.Series.Add(series41);
            this.Cht3.Series.Add(series42);
            this.Cht3.Series.Add(series43);
            this.Cht3.Series.Add(series44);
            this.Cht3.Size = new System.Drawing.Size(287, 91);
            this.Cht3.TabIndex = 12;
            title12.Name = "Title1";
            title12.Text = "EMG Envelope (WIP)";
            this.Cht3.Titles.Add(title12);
            // 
            // BtnTestInterop
            // 
            this.BtnTestInterop.Location = new System.Drawing.Point(315, 351);
            this.BtnTestInterop.Name = "BtnTestInterop";
            this.BtnTestInterop.Size = new System.Drawing.Size(75, 23);
            this.BtnTestInterop.TabIndex = 13;
            this.BtnTestInterop.Text = "Hello";
            this.BtnTestInterop.UseVisualStyleBackColor = true;
            this.BtnTestInterop.Click += new System.EventHandler(this.BtnTestInterop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 395);
            this.Controls.Add(this.BtnTestInterop);
            this.Controls.Add(this.Cht3);
            this.Controls.Add(this.GrpCursor);
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
            this.Text = "MuscleController Frontend";
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
    }
}


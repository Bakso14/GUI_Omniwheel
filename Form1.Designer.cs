﻿namespace Penelitian_Push_Up_Counter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportToTxtButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kd_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ki_textbox = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.kp_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.character_split = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.index_data1 = new System.Windows.Forms.TextBox();
            this.graph_control = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.index_data2 = new System.Windows.Forms.TextBox();
            this.MapUtama = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.auto_load = new System.Windows.Forms.CheckBox();
            this.gps_serial = new System.Windows.Forms.CheckBox();
            this.index_long = new System.Windows.Forms.Label();
            this.index_long_var = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.index_lat = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.index_lat_var = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GPS = new System.Windows.Forms.TabPage();
            this.Grafik = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.longitude_goal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.latitude_goal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.graph_control.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GPS.SuspendLayout();
            this.Grafik.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBaudrate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 21);
            this.button4.TabIndex = 38;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM PORT";
            // 
            // cBoxBaudrate
            // 
            this.cBoxBaudrate.FormattingEnabled = true;
            this.cBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.cBoxBaudrate.Location = new System.Drawing.Point(142, 50);
            this.cBoxBaudrate.Name = "cBoxBaudrate";
            this.cBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cBoxBaudrate.TabIndex = 6;
            this.cBoxBaudrate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(142, 23);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(32, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(101, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(20, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(229, 171);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 82);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(32, 135);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(272, 27);
            this.tBoxDataOut.TabIndex = 4;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(32, 283);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(272, 39);
            this.tBoxDataIn.TabIndex = 5;
            this.tBoxDataIn.TextChanged += new System.EventHandler(this.tBoxDataIn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Send Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Receive Data";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 328);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Always Update";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(174, 328);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Add to Old Data";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Data1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Data2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(962, 433);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // exportToTxtButton
            // 
            this.exportToTxtButton.Location = new System.Drawing.Point(134, 43);
            this.exportToTxtButton.Name = "exportToTxtButton";
            this.exportToTxtButton.Size = new System.Drawing.Size(44, 30);
            this.exportToTxtButton.TabIndex = 13;
            this.exportToTxtButton.Text = "Save";
            this.exportToTxtButton.UseVisualStyleBackColor = true;
            this.exportToTxtButton.Click += new System.EventHandler(this.exportToTxtButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear Graph 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 26);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Tampilkan Graph";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.kd_textbox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ki_textbox);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.kp_textbox);
            this.groupBox3.Location = new System.Drawing.Point(794, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 131);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID Controller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "SP";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(189, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "KD";
            // 
            // kd_textbox
            // 
            this.kd_textbox.Location = new System.Drawing.Point(57, 92);
            this.kd_textbox.Name = "kd_textbox";
            this.kd_textbox.Size = new System.Drawing.Size(40, 20);
            this.kd_textbox.TabIndex = 39;
            this.kd_textbox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "KI";
            // 
            // ki_textbox
            // 
            this.ki_textbox.Location = new System.Drawing.Point(57, 63);
            this.ki_textbox.Name = "ki_textbox";
            this.ki_textbox.Size = new System.Drawing.Size(40, 20);
            this.ki_textbox.TabIndex = 37;
            this.ki_textbox.Text = "0";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(139, 52);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(121, 57);
            this.button15.TabIndex = 34;
            this.button15.Text = "KIRIM";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "KP";
            // 
            // kp_textbox
            // 
            this.kp_textbox.Location = new System.Drawing.Point(57, 34);
            this.kp_textbox.Name = "kp_textbox";
            this.kp_textbox.Size = new System.Drawing.Size(40, 20);
            this.kp_textbox.TabIndex = 35;
            this.kp_textbox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Character Split";
            // 
            // character_split
            // 
            this.character_split.Location = new System.Drawing.Point(88, 44);
            this.character_split.Name = "character_split";
            this.character_split.Size = new System.Drawing.Size(40, 20);
            this.character_split.TabIndex = 43;
            this.character_split.Text = ",";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Index Data1";
            // 
            // index_data1
            // 
            this.index_data1.Location = new System.Drawing.Point(88, 69);
            this.index_data1.Name = "index_data1";
            this.index_data1.Size = new System.Drawing.Size(40, 20);
            this.index_data1.TabIndex = 45;
            this.index_data1.Text = "0";
            // 
            // graph_control
            // 
            this.graph_control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.graph_control.Controls.Add(this.label11);
            this.graph_control.Controls.Add(this.index_data2);
            this.graph_control.Controls.Add(this.button3);
            this.graph_control.Controls.Add(this.label10);
            this.graph_control.Controls.Add(this.checkBox3);
            this.graph_control.Controls.Add(this.exportToTxtButton);
            this.graph_control.Controls.Add(this.index_data1);
            this.graph_control.Controls.Add(this.character_split);
            this.graph_control.Controls.Add(this.label9);
            this.graph_control.Location = new System.Drawing.Point(1069, 19);
            this.graph_control.Name = "graph_control";
            this.graph_control.Size = new System.Drawing.Size(228, 131);
            this.graph_control.TabIndex = 46;
            this.graph_control.TabStop = false;
            this.graph_control.Text = "Graph Control";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Index Data2";
            // 
            // index_data2
            // 
            this.index_data2.Location = new System.Drawing.Point(88, 92);
            this.index_data2.Name = "index_data2";
            this.index_data2.Size = new System.Drawing.Size(40, 20);
            this.index_data2.TabIndex = 47;
            this.index_data2.Text = "0";
            // 
            // MapUtama
            // 
            this.MapUtama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapUtama.Bearing = 0F;
            this.MapUtama.CanDragMap = true;
            this.MapUtama.EmptyTileColor = System.Drawing.Color.Navy;
            this.MapUtama.GrayScaleMode = false;
            this.MapUtama.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MapUtama.LevelsKeepInMemory = 5;
            this.MapUtama.Location = new System.Drawing.Point(0, 0);
            this.MapUtama.MarkersEnabled = true;
            this.MapUtama.MaxZoom = 2;
            this.MapUtama.MinZoom = 2;
            this.MapUtama.MouseWheelZoomEnabled = true;
            this.MapUtama.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MapUtama.Name = "MapUtama";
            this.MapUtama.NegativeMode = false;
            this.MapUtama.PolygonsEnabled = true;
            this.MapUtama.RetryLoadTile = 0;
            this.MapUtama.RoutesEnabled = true;
            this.MapUtama.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MapUtama.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MapUtama.ShowTileGridLines = false;
            this.MapUtama.Size = new System.Drawing.Size(959, 437);
            this.MapUtama.TabIndex = 47;
            this.MapUtama.Zoom = 0D;
            this.MapUtama.Click += new System.EventHandler(this.MapUtama_Click);
            this.MapUtama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapUtama_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.auto_load);
            this.groupBox4.Controls.Add(this.gps_serial);
            this.groupBox4.Controls.Add(this.index_long);
            this.groupBox4.Controls.Add(this.index_long_var);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.index_lat);
            this.groupBox4.Controls.Add(this.Longitude);
            this.groupBox4.Controls.Add(this.index_lat_var);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.Latitude);
            this.groupBox4.Location = new System.Drawing.Point(482, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 131);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Load Map";
            // 
            // auto_load
            // 
            this.auto_load.AutoSize = true;
            this.auto_load.Location = new System.Drawing.Point(167, 77);
            this.auto_load.Name = "auto_load";
            this.auto_load.Size = new System.Drawing.Size(75, 17);
            this.auto_load.TabIndex = 52;
            this.auto_load.Text = "Auto Load";
            this.auto_load.UseVisualStyleBackColor = true;
            // 
            // gps_serial
            // 
            this.gps_serial.AutoSize = true;
            this.gps_serial.Location = new System.Drawing.Point(167, 97);
            this.gps_serial.Name = "gps_serial";
            this.gps_serial.Size = new System.Drawing.Size(100, 17);
            this.gps_serial.TabIndex = 48;
            this.gps_serial.Text = "Baca dari Serial";
            this.gps_serial.UseVisualStyleBackColor = true;
            // 
            // index_long
            // 
            this.index_long.AutoSize = true;
            this.index_long.Location = new System.Drawing.Point(9, 103);
            this.index_long.Name = "index_long";
            this.index_long.Size = new System.Drawing.Size(60, 13);
            this.index_long.TabIndex = 50;
            this.index_long.Text = "Index Long";
            // 
            // index_long_var
            // 
            this.index_long_var.Location = new System.Drawing.Point(69, 99);
            this.index_long_var.Name = "index_long_var";
            this.index_long_var.Size = new System.Drawing.Size(40, 20);
            this.index_long_var.TabIndex = 51;
            this.index_long_var.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Longitude";
            // 
            // index_lat
            // 
            this.index_lat.AutoSize = true;
            this.index_lat.Location = new System.Drawing.Point(9, 80);
            this.index_lat.Name = "index_lat";
            this.index_lat.Size = new System.Drawing.Size(51, 13);
            this.index_lat.TabIndex = 48;
            this.index_lat.Text = "Index Lat";
            // 
            // Longitude
            // 
            this.Longitude.Location = new System.Drawing.Point(69, 52);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(87, 20);
            this.Longitude.TabIndex = 37;
            this.Longitude.Text = "112.72720018600343";
            // 
            // index_lat_var
            // 
            this.index_lat_var.Location = new System.Drawing.Point(69, 76);
            this.index_lat_var.Name = "index_lat_var";
            this.index_lat_var.Size = new System.Drawing.Size(40, 20);
            this.index_lat_var.TabIndex = 49;
            this.index_lat_var.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 57);
            this.button1.TabIndex = 34;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Latitude";
            // 
            // Latitude
            // 
            this.Latitude.Location = new System.Drawing.Point(69, 23);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(87, 20);
            this.Latitude.TabIndex = 35;
            this.Latitude.Text = "-7.313465349245249";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.GPS);
            this.tabControl1.Controls.Add(this.Grafik);
            this.tabControl1.Location = new System.Drawing.Point(327, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 463);
            this.tabControl1.TabIndex = 48;
            // 
            // GPS
            // 
            this.GPS.Controls.Add(this.MapUtama);
            this.GPS.Location = new System.Drawing.Point(4, 22);
            this.GPS.Name = "GPS";
            this.GPS.Padding = new System.Windows.Forms.Padding(3);
            this.GPS.Size = new System.Drawing.Size(962, 437);
            this.GPS.TabIndex = 0;
            this.GPS.Text = "GPS";
            this.GPS.UseVisualStyleBackColor = true;
            // 
            // Grafik
            // 
            this.Grafik.Controls.Add(this.chart1);
            this.Grafik.Location = new System.Drawing.Point(4, 22);
            this.Grafik.Name = "Grafik";
            this.Grafik.Padding = new System.Windows.Forms.Padding(3);
            this.Grafik.Size = new System.Drawing.Size(962, 437);
            this.Grafik.TabIndex = 1;
            this.Grafik.Text = "Grafik";
            this.Grafik.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.longitude_goal);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.latitude_goal);
            this.groupBox5.Location = new System.Drawing.Point(32, 367);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 101);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GPS Send";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Longitude";
            // 
            // longitude_goal
            // 
            this.longitude_goal.Location = new System.Drawing.Point(68, 60);
            this.longitude_goal.Name = "longitude_goal";
            this.longitude_goal.Size = new System.Drawing.Size(108, 20);
            this.longitude_goal.TabIndex = 37;
            this.longitude_goal.Text = "112.7555711325154";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 49);
            this.button2.TabIndex = 34;
            this.button2.Text = "KIRIM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Latitude";
            // 
            // latitude_goal
            // 
            this.latitude_goal.Location = new System.Drawing.Point(68, 31);
            this.latitude_goal.Name = "latitude_goal";
            this.latitude_goal.Size = new System.Drawing.Size(108, 20);
            this.latitude_goal.TabIndex = 35;
            this.latitude_goal.Text = "-7.368498012597734";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 627);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.graph_control);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBoxDataIn);
            this.Controls.Add(this.tBoxDataOut);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Universal PID GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.graph_control.ResumeLayout(false);
            this.graph_control.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GPS.ResumeLayout(false);
            this.Grafik.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxBaudrate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button exportToTxtButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kp_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ki_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kd_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox character_split;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox index_data1;
        private System.Windows.Forms.GroupBox graph_control;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox index_data2;
        private GMap.NET.WindowsForms.GMapControl MapUtama;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Latitude;
        private System.Windows.Forms.Label index_long;
        private System.Windows.Forms.TextBox index_long_var;
        private System.Windows.Forms.Label index_lat;
        private System.Windows.Forms.TextBox index_lat_var;
        private System.Windows.Forms.CheckBox gps_serial;
        private System.Windows.Forms.CheckBox auto_load;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GPS;
        private System.Windows.Forms.TabPage Grafik;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox longitude_goal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox latitude_goal;
        private System.Windows.Forms.Button button4;
    }
}


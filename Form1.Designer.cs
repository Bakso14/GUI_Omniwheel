namespace Penelitian_Push_Up_Counter
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportToTxtButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.sp_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kp_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ki_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kd_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dir_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxBaudrate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
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
            this.cBoxBaudrate.Text = "115200";
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
            this.groupBox2.Location = new System.Drawing.Point(32, 149);
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
            this.btnSendData.Location = new System.Drawing.Point(229, 152);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 82);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.Location = new System.Drawing.Point(32, 116);
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
            this.tBoxDataIn.Location = new System.Drawing.Point(32, 264);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(272, 67);
            this.tBoxDataIn.TabIndex = 5;
            this.tBoxDataIn.TextChanged += new System.EventHandler(this.tBoxDataIn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Send Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Receive Data";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 345);
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
            this.checkBox2.Location = new System.Drawing.Point(35, 368);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Add to Old Data";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(640, 7);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(777, 271);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // exportToTxtButton
            // 
            this.exportToTxtButton.Location = new System.Drawing.Point(143, 345);
            this.exportToTxtButton.Name = "exportToTxtButton";
            this.exportToTxtButton.Size = new System.Drawing.Size(75, 35);
            this.exportToTxtButton.TabIndex = 13;
            this.exportToTxtButton.Text = "Save";
            this.exportToTxtButton.UseVisualStyleBackColor = true;
            this.exportToTxtButton.Click += new System.EventHandler(this.exportToTxtButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 35);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear Graph 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(35, 391);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 17);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "Tampilkan Graph";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(640, 299);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(777, 271);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 35);
            this.button4.TabIndex = 21;
            this.button4.Text = "Clear Graph 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(345, 588);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(278, 271);
            this.button7.TabIndex = 25;
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(640, 588);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(777, 271);
            this.chart3.TabIndex = 24;
            this.chart3.Text = "chart3";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(224, 427);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 35);
            this.button8.TabIndex = 26;
            this.button8.Text = "Clear Graph 3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(143, 386);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 35);
            this.button9.TabIndex = 27;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(143, 427);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 35);
            this.button10.TabIndex = 28;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 642);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(345, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(278, 271);
            this.button6.TabIndex = 23;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(345, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(278, 271);
            this.button5.TabIndex = 22;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 35);
            this.button2.TabIndex = 30;
            this.button2.Text = "V20";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(73, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 34);
            this.button11.TabIndex = 31;
            this.button11.Text = "ChangeDir";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(35, 468);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 100);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motor";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(201, 59);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(59, 35);
            this.button16.TabIndex = 37;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(201, 19);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(59, 34);
            this.button17.TabIndex = 36;
            this.button17.Text = "PIDM3";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(138, 59);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(59, 35);
            this.button14.TabIndex = 35;
            this.button14.Text = "PIDM2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(138, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 34);
            this.button15.TabIndex = 34;
            this.button15.Text = "PIDM1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(73, 59);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(59, 35);
            this.button13.TabIndex = 33;
            this.button13.Text = "StopAll";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 59);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 35);
            this.button12.TabIndex = 32;
            this.button12.Text = "V10";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // sp_textbox
            // 
            this.sp_textbox.Location = new System.Drawing.Point(37, 600);
            this.sp_textbox.Name = "sp_textbox";
            this.sp_textbox.Size = new System.Drawing.Size(40, 20);
            this.sp_textbox.TabIndex = 33;
            this.sp_textbox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "KP";
            // 
            // kp_textbox
            // 
            this.kp_textbox.Location = new System.Drawing.Point(156, 600);
            this.kp_textbox.Name = "kp_textbox";
            this.kp_textbox.Size = new System.Drawing.Size(40, 20);
            this.kp_textbox.TabIndex = 35;
            this.kp_textbox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "KI";
            // 
            // ki_textbox
            // 
            this.ki_textbox.Location = new System.Drawing.Point(212, 600);
            this.ki_textbox.Name = "ki_textbox";
            this.ki_textbox.Size = new System.Drawing.Size(40, 20);
            this.ki_textbox.TabIndex = 37;
            this.ki_textbox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "KD";
            // 
            // kd_textbox
            // 
            this.kd_textbox.Location = new System.Drawing.Point(263, 600);
            this.kd_textbox.Name = "kd_textbox";
            this.kd_textbox.Size = new System.Drawing.Size(40, 20);
            this.kd_textbox.TabIndex = 39;
            this.kd_textbox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Dir";
            // 
            // dir_textbox
            // 
            this.dir_textbox.Location = new System.Drawing.Point(80, 600);
            this.dir_textbox.Name = "dir_textbox";
            this.dir_textbox.Size = new System.Drawing.Size(40, 20);
            this.dir_textbox.TabIndex = 41;
            this.dir_textbox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 931);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dir_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kd_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ki_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kp_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sp_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exportToTxtButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
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
            this.Text = "Omniwheel Education Platform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button exportToTxtButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox sp_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kp_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ki_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kd_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dir_textbox;
    }
}


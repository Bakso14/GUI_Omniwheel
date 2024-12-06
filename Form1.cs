using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Sockets;

namespace Penelitian_Push_Up_Counter
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        string Address;
        int i = 0;
        int j = 0;
        int k = 0;
        string kecepatan_setpoint = "0";
        string kp = "0";
        string ki = "0";
        string kd = "0";
        string setpoint = "0" ;
        string kode = "0";
        string dir = "0";
        string function_code = "0";

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            checkBox1.Checked = true;
            checkBox2.Checked = false;

            groupBox1.Location = new System.Drawing.Point((tabControl1.Width/2) - groupBox1.Width/2, (tabControl1.Height/2) - groupBox1.Height);
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudrate.Text);
                serialPort1.DataBits = Convert.ToInt32("8");
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");

                serialPort1.Open();
                progressBar1.Value = 100;
            }

            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                serialPort1.Write(dataOUT);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadLine(); // mengambil data dengan pembatas enter
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            string[] pisah_data = dataIN.Split(';');

            try
            {
                button5.Text = pisah_data[0];
                button6.Text = pisah_data[1];
                button7.Text = pisah_data[2];
                if (checkBox3.Checked)
                {
                    i++;
                    this.chart1.Series["Series1"].Points.AddXY(i, pisah_data[0]);
                    j++;
                    this.chart2.Series["Series1"].Points.AddXY(j, pisah_data[1]);
                    k++;
                    this.chart3.Series["Series1"].Points.AddXY(j, pisah_data[2]);

                }
                
                if (G1.Checked)
                {
                    i++;
                    this.chart1.Series["Series1"].Points.AddXY(i, pisah_data[0]);
                }
                
                if (G2.Checked)
                {
                    j++;
                    this.chart2.Series["Series1"].Points.AddXY(j, pisah_data[1]);
                }
                
                if (G3.Checked)
                {
                    k++;
                    this.chart3.Series["Series1"].Points.AddXY(j, pisah_data[2]);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error String Input Tidak Sesuai:\n" + "\"" + dataIN + "\"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (checkBox1.Checked)
            {
                tBoxDataIn.Text = dataIN;

            }
            else if (checkBox2.Checked)
            {
                tBoxDataIn.AppendText(dataIN+"\n");
                
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = true;
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tBoxDataIn.Text != "")
            {
                tBoxDataIn.Text = "";
            }

            chart1.Series["Series1"].Points.Clear();
            i = 0;

            chart2.Series["Series1"].Points.Clear();
            j = 0;

            chart3.Series["Series1"].Points.Clear();
            k = 0;
        }

        
        private void exportToTxtButton_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to choose the export file location.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path.
                string filePath = saveFileDialog.FileName;

                // Get chart data from the chart control.
                Chart chart = chart1; // Replace "yourChartControl" with your chart control's name
                Series series = chart.Series[0]; // Assuming you have only one series

                // Create a StreamWriter to write data to the text file.
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write the data from the chart to the text file.
                    sw.WriteLine("X-Value\tY-Value");

                    foreach (var point in series.Points)
                    {
                        sw.WriteLine($"{point.XValue}\t{point.YValues[0]}");
                    }
                }

                MessageBox.Show("Data exported to TXT successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Points.Clear();
            i = 0;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
            j = 0;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            chart3.Series["Series1"].Points.Clear();
            k = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to choose the export file location.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path.
                string filePath = saveFileDialog.FileName;

                // Get chart data from the chart control.
                Chart chart = chart2; // Replace "yourChartControl" with your chart control's name
                Series series = chart.Series[0]; // Assuming you have only one series

                // Create a StreamWriter to write data to the text file.
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write the data from the chart to the text file.
                    sw.WriteLine("X-Value\tY-Value");

                    foreach (var point in series.Points)
                    {
                        sw.WriteLine($"{point.XValue}\t{point.YValues[0]}");
                    }
                }

                MessageBox.Show("Data exported to TXT successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to choose the export file location.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path.
                string filePath = saveFileDialog.FileName;

                // Get chart data from the chart control.
                Chart chart = chart3; // Replace "yourChartControl" with your chart control's name
                Series series = chart.Series[0]; // Assuming you have only one series

                // Create a StreamWriter to write data to the text file.
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write the data from the chart to the text file.
                    sw.WriteLine("X-Value\tY-Value");

                    foreach (var point in series.Points)
                    {
                        sw.WriteLine($"{point.XValue}\t{point.YValues[0]}");
                    }
                }

                MessageBox.Show("Data exported to TXT successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kecepatan_setpoint = "20";
            function_code = "2";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + ",0,0,0,"+ kecepatan_setpoint + "," + kecepatan_setpoint + "," + kecepatan_setpoint + ",0,0,0");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kecepatan_setpoint = "10";
            function_code = "2";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + ",0,0,0," + kecepatan_setpoint + "," + kecepatan_setpoint + "," + kecepatan_setpoint + ",0,0,0");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kecepatan_setpoint = "20";
            function_code = "2";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + ",1,1,1," + kecepatan_setpoint + "," + kecepatan_setpoint + "," + kecepatan_setpoint + ",0,0,0");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fungsi_semua_motor_berhenti();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                setpoint = sp_textbox.Text;
                dir = dir_textbox.Text;
                kp = kp_textbox.Text;
                ki = ki_textbox.Text;
                kd = kd_textbox.Text;
                kode = "94";
                function_code = "0";
                serialPort1.Write(function_code + "," + kode + "," + setpoint + "," + dir + "," + kp + "," + ki + "," + kd + ",0,0,0");
                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                setpoint = sp_textbox.Text;
                dir = dir_textbox.Text;
                kp = kp_textbox.Text;
                ki = ki_textbox.Text;
                kd = kd_textbox.Text;
                kode = "7";
                function_code = "0";
                serialPort1.Write(function_code + "," + kode + "," + setpoint + "," + dir + "," + kp + "," + ki + "," + kd + ",0,0,0");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                setpoint = sp_textbox.Text;
                kp = kp_textbox.Text;
                ki = ki_textbox.Text;
                kd = kd_textbox.Text;
                kode = "10";
                function_code = "0";
                serialPort1.Write(function_code + "," + kode + "," + setpoint + "," + dir + "," + kp + "," + ki + "," + kd + ",0,0,0");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                kode = "7";
                function_code = "1";
                serialPort1.Write(function_code + "," + kode + "," + Speed2.Text + "," + Dir2.Text + "," + TimerM2.Text + ",0,0" + ",0,0,0");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                kode = "10";
                function_code = "1";
                serialPort1.Write(function_code + "," + kode + "," + Speed3.Text + "," + Dir3.Text + "," + TimerM3.Text + ",0,0" + ",0,0,0");
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                function_code = "3";
                serialPort1.Write(function_code + "," + Dir1.Text + "," + Speed1.Text + "," + TimerM1.Text + "," + Dir2.Text + "," + Speed2.Text + "," + TimerM2.Text + "," + Dir3.Text + "," + Speed3.Text + "," + TimerM3.Text);
            }
        }


        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendM1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                kode = "94";
                function_code = "1";
                serialPort1.Write(function_code + "," + kode + "," + Speed1.Text + "," + Dir1.Text + "," + TimerM1.Text + ",0,0" + ",0,0,0");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            fungsi_semua_motor_berhenti();
        }

        private void fungsi_semua_motor_berhenti()
        {
            kecepatan_setpoint = "0";
            function_code = "2";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + ",0,0,0," + kecepatan_setpoint + "," + kecepatan_setpoint + "," + kecepatan_setpoint + ",0,0,0");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            fungsi_semua_motor_berhenti();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            fungsi_semua_motor_berhenti();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double[] matrix_kecepatan = { -0.3333, 0.5774, 0.0317, -0.3333, -0.5774, 0.0317, 0.6667, 0, 0.0317 };
            double V1, V2, V3;
            V3 = matrix_kecepatan[0] * Convert.ToDouble(Vx.Text) + matrix_kecepatan[1] * Convert.ToDouble(Vy.Text) + matrix_kecepatan[2] * Convert.ToDouble(W.Text);
            V2 = matrix_kecepatan[3] * Convert.ToDouble(Vx.Text) + matrix_kecepatan[4] * Convert.ToDouble(Vy.Text) + matrix_kecepatan[5] * Convert.ToDouble(W.Text);
            V1 = matrix_kecepatan[6] * Convert.ToDouble(Vx.Text) + matrix_kecepatan[7] * Convert.ToDouble(Vy.Text) + matrix_kecepatan[8] * Convert.ToDouble(W.Text);


            label60.Text = V1.ToString();
            label61.Text = V2.ToString();
            label62.Text = V3.ToString();

            int[] arah_motor = { 1, 1, 1 };

            if (V1 < 0)
            {
                arah_motor[0] = 0;
                V1 = Math.Abs(V1);
            }

            if (V2 < 0)
            {
                arah_motor[1] = 0;
                V2 = Math.Abs(V2);
            }

            if (V3 < 0)
            {
                arah_motor[2] = 0;
                V3 = Math.Abs(V3);
            }

            function_code = "3";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + "," + arah_motor[0].ToString() + "," + arah_motor[1].ToString() + "," + arah_motor[2].ToString() + "," + V1.ToString() + "," + V2.ToString() + "," + V3.ToString() + "," + Timer_Point_Movement.Text + "," + Timer_Point_Movement.Text + "," + Timer_Point_Movement.Text);
            }
        }

        private void Point_Movement_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            function_code = "2";
            int[] arah_motor = { 1, 1, 1 };

            if (comboBoxM1.Text == "CW")
            {
                arah_motor[0] = 1;
            }
            else if (comboBoxM1.Text == "CCW")
            {
                arah_motor[0] = 0;
            }

            if (comboBoxM2.Text == "CW")
            {
                arah_motor[1] = 1;
            }
            else if (comboBoxM2.Text == "CCW")
            {
                arah_motor[1] = 0;
            }

            if (comboBoxM3.Text == "CW")
            {
                arah_motor[2] = 1;
            }
            else if (comboBoxM3.Text == "CCW")
            {
                arah_motor[2] = 0;
            }


            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + "," + arah_motor[0].ToString() + "," + arah_motor[1].ToString() + "," + arah_motor[2].ToString() + "," + base_movement_M1.Text + "," + base_movement_M2.Text + "," + base_movement_M3.Text + ",0,0,0");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double[] matrix_kecepatan = { -0.3333, 0.5774, 0.0317, -0.3333, -0.5774, 0.0317, 0.6667, 0, 0.0317 };
            double V1, V2, V3;
            V3 = matrix_kecepatan[0] * Convert.ToDouble(Vx_Base.Text) + matrix_kecepatan[1] * Convert.ToDouble(Vy_Base.Text) + matrix_kecepatan[2] * Convert.ToDouble(W_Base.Text);
            V2 = matrix_kecepatan[3] * Convert.ToDouble(Vx_Base.Text) + matrix_kecepatan[4] * Convert.ToDouble(Vy_Base.Text) + matrix_kecepatan[5] * Convert.ToDouble(W_Base.Text);
            V1 = matrix_kecepatan[6] * Convert.ToDouble(Vx_Base.Text) + matrix_kecepatan[7] * Convert.ToDouble(Vy_Base.Text) + matrix_kecepatan[8] * Convert.ToDouble(W_Base.Text);

            int[] arah_motor = { 1, 1, 1 };

            if (V1 < 0)
            {
                arah_motor[0] = 0;
                V1 = Math.Abs(V1);
            }

            if (V2 < 0)
            {
                arah_motor[1] = 0;
                V2 = Math.Abs(V2);
            }

            if (V3 < 0)
            {
                arah_motor[2] = 0;
                V3 = Math.Abs(V3);
            }

            function_code = "2";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + "," + arah_motor[0].ToString() + "," + arah_motor[1].ToString() + "," + arah_motor[2].ToString() + "," + V1.ToString() + "," + V2.ToString() + "," + V3.ToString() + ",0,0,0");
            }
        }

        private void Motor_Velocity_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxM1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

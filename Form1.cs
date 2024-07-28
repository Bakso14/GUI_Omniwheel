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
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
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
                else if (G1.Checked)
                {
                    i++;
                    this.chart1.Series["Series1"].Points.AddXY(i, pisah_data[0]);
                }
                else if (G2.Checked)
                {
                    j++;
                    this.chart2.Series["Series1"].Points.AddXY(j, pisah_data[1]);
                }
                else if (G3.Checked)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tBoxDataIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
            j = 0;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "15";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            kecepatan_setpoint = "0";
            function_code = "2";
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(function_code + ",0,0,0," + kecepatan_setpoint + "," + kecepatan_setpoint + "," + kecepatan_setpoint + ",0,0,0");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                kode = "94";
                function_code = "1";
                serialPort1.Write(function_code + "," + kode + "," + Speed1.Text + "," + Dir1.Text + "," + TimerM1.Text + ",0,0" + ",0,0,0");
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
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

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                function_code = "3";
                serialPort1.Write(function_code + "," + Dir1.Text + "," + Speed1.Text + "," + TimerM1.Text + "," + Dir2.Text + "," + Speed2.Text + "," + TimerM2.Text + "," + Dir3.Text + "," + Speed3.Text + "," + TimerM3.Text);
            }
        }
    }
}

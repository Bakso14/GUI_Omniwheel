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
using GMap.NET.MapProviders;
using GMap.NET;

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

            try
            {
                string[] pisah_data = dataIN.Split(character_split.Text[0]);

                if (checkBox3.Checked)
                {
                    i++;
                    this.chart1.Series[0].Points.AddXY(i, pisah_data[Convert.ToInt16(index_data1.Text)]);
                    this.chart1.Series[1].Points.AddXY(i, pisah_data[Convert.ToInt16(index_data2.Text)]);
                }

                if (gps_serial.Checked)
                {
                    Latitude.Text = pisah_data[Convert.ToInt16(index_lat.Text)];
                    Longitude.Text = pisah_data[Convert.ToInt16(index_long.Text)];
                }



            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error String Input Tidak Sesuai:\n" + "\"" + dataIN + "\"", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (auto_load.Checked)
            {
                MapUtama.DragButton = MouseButtons.Left;
                MapUtama.MapProvider = GMapProviders.GoogleMap;
                double lat = Convert.ToDouble(Latitude.Text);
                double lon = Convert.ToDouble(Longitude.Text);
                MapUtama.Position = new PointLatLng(lat, lon);
                MapUtama.MinZoom = 1;
                MapUtama.MaxZoom = 100;
                MapUtama.Zoom = 15;
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
                Series series_set_point = chart.Series[1];

                // Create a StreamWriter to write data to the text file.
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Write the data from the chart to the text file.
                    sw.WriteLine("X-Value\tY-Value");

                    foreach (var point in series.Points)
                    {
                        foreach(var point_setpoint in series_set_point.Points)
                        {
                            if(point.XValue == point_setpoint.XValue)
                            {
                                sw.WriteLine($"{point.XValue}\t{point.YValues[0]}\t{point_setpoint.YValues[0]}");
                            }
                        }
                        
                    }
                }

                MessageBox.Show("Data exported to TXT successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            i = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tBoxDataIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                setpoint = textBox5.Text;
                kp = kp_textbox.Text;
                ki = ki_textbox.Text;
                kd = kd_textbox.Text;
                //serialPort1.Write(kp + "," + ki + "," + kd + "," + setpoint);
                serialPort1.Write(setpoint + "," + kp + "," + ki + "," + kd);
                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MapUtama.DragButton = MouseButtons.Left;
            MapUtama.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(Latitude.Text);
            double lon = Convert.ToDouble(Longitude.Text);
            MapUtama.Position = new PointLatLng(lat, lon);
            MapUtama.MinZoom = 1;
            MapUtama.MaxZoom = 100;
            MapUtama.Zoom = 15;
        }

        private void MapUtama_Click(object sender, EventArgs e)
        {
            
        }

        private void MapUtama_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

// AT2.1 | Scripting
// Arduino & Winform home climate control system prototype
// Semester 2, Term 2, 2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Scripting2._1
{
    public partial class Form1 : Form
    {
        public SerialPort myPort = new SerialPort();
        bool redLightStatus = false;

        public Form1()
        {
            InitializeComponent();
            Init();
        }
        // Method to initialise and setup serial port which connects to the Arduino
        // Use data recieved method and a try catch block for any possible exception.
        private void Init()
        {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 9600;
                myPort.PortName = "COM4"; // modify to your local COM
                myPort.Parity = Parity.None;
                myPort.StopBits = StopBits.One;
                myPort.DataBits = 8;
                myPort.Handshake = Handshake.None;
                myPort.RtsEnable = true;
                myPort.Open();
                myPort.DataReceived += myPort_DataReceived;
            }
            catch (Exception)
            {
                MessageBox.Show("Not connected");
            }
        }
        // Serial port data received method which reads the data from the Arduino as string line.
        // Then uses the line recieved method which converts the raw data in combination with the line received event.
        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = myPort.ReadLine(); // read data from Arduino
            BeginInvoke(new LineReceivedEvent(LineReceived), line);
        }

        private delegate void LineReceivedEvent(string line);

        // convert raw data into correct format
        private void LineReceived(string line)
        {
            OutsideTempBox.Clear();
            InsideHumidityBox.Clear(); // clear text boxes
            InsideTempBox.Clear();
            // Split the data for each appropraite text box
            String[] dataHumTemp = line.Split(',');
            OutsideTempBox.Text = dataHumTemp[0];
            InsideHumidityBox.Text = dataHumTemp[1];
            InsideTempBox.Text = dataHumTemp[2];
        }
        // Click button method for turning the red LED light on and off.
        private void RedLEDButton_Click(object sender, EventArgs e)
        {
            if (redLightStatus == false)
            {
                myPort.WriteLine("100");
                redLightStatus = true;
            }
            else
            {
                myPort.WriteLine("101");
                redLightStatus = false;
            }
        }
        // Method for setting max temperature after which the buzzer will sound like an alarm.
        private void TempMaxButton_Click(object sender, EventArgs e)
        {
            
            myPort.WriteLine(TempComboBox.Text);

        }
    }
}


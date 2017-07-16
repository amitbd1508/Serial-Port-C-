using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadComPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            openPort();
        }
        private void openPort()
        {
            try
            {


                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBox1.SelectedItem.ToString();
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    
                }


            }
            catch
            {
                


            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.WriteLine(txtMessage.Text.Trim());
                else
                    MessageBox.Show("Open Serial Port ");
            }
            catch
            {
                MessageBox.Show("Serial Port Problem ");
            }
        }

        

    }
}

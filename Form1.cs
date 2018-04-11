using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Servo_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            
            if(serialPort1.IsOpen == false)
            serialPort1.Open();
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                char n = Convert.ToChar(Convert.ToInt32(txtValue1.Text)); // send the signals
                char m = Convert.ToChar(Convert.ToInt32(txtValue2.Text));
                char p = Convert.ToChar(Convert.ToInt32(txtValue3.Text));
                serialPort1.Write(n.ToString());
                serialPort1.Write(m.ToString());
                serialPort1.Write(p.ToString());
                serialPort1.Close();
            }
            
        }
    }
}

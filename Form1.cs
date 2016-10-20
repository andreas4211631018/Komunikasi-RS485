using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        int a;
        string rxString;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Connect")
            {
                button1.Text = "Disconnect";
                serialPort1.Open();
                RichTextBox1.Text = "";
                a = 0;
            }
            else
            {
                button1.Text = "Connect";
                serialPort1.Close();
            }
          }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxString = serialPort1.ReadLine();
            this.Invoke(new EventHandler(DisplayText));
        }
        private void DisplayText(object sender, EventArgs e)
        {
            RichTextBox1.AppendText(rxString);
            RichTextBox1.ScrollToCaret();
            chart1.Series["Series1"].Points.AddXY(a, Convert.ToInt16(rxString));
            a++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }
       }
   } 
    


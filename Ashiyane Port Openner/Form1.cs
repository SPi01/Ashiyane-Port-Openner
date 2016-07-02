using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO.Ports;

namespace Ashiyane_Port_Openner
{
    public partial class Form1 : Form
    {
        static Socket port32;   
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter the port number !","Error");
                textBox1.Focus();
            }
            else
            {
                try
                {
                    int a;
                    a = int.Parse(textBox1.Text);
                    port32 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, a);
                    port32.Bind(ipLocal);
                    port32.Listen(100);
                    textBox1.Text = "Request Complete !";
                    MessageBox.Show("Your requested port has been opened and would be open until you close this program.");
                }
                catch
                {
                    MessageBox.Show("Please enter numeric character !", "Error");
                }
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

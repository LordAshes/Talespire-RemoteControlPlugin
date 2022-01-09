using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            SendCommand("Up");
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            SendCommand("Down");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            SendCommand("Left");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            SendCommand("Right");
        }

        private void SendCommand(string cmd)
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));

            Socket client = new Socket(SocketType.Stream, ProtocolType.Tcp);
            client.Connect(remoteEndPoint);
            client.Send(Encoding.ASCII.GetBytes(txtCharacterName.Text+","+cmd+"\n"));

            client.Close();
            client.Dispose();
        }
    }
}

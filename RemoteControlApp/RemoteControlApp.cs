using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace RemoteControlApp
{
    public partial class RemoteControlApp : Form
    {
        public RemoteControlApp()
        {
            InitializeComponent();
        }

        private void SendCommand(string sender, string cmd)
        {
            cmd = cmd.ToUpper();

            if (ckbFaceWhenMoving.Checked == true)
            {
                if (!cmd.ToUpper().Contains("ROTATE") && sender.ToUpper()!="CAMERA")
                {
                    cmd = cmd.Replace("FORWARD", "FORWARDANDFACE");
                    cmd = cmd.Replace("BACKWARD", "BACKWARDANDFACE");
                    cmd = cmd.Replace("RIGHT", "RIGHTANDFACE");
                    cmd = cmd.Replace("LEFT", "LEFTANDFACE");
                }
            }

            lstCommands.Items.Insert(0,sender + "," + cmd + "\n");
            lstCommands.Refresh();

            while (lstCommands.Items.Count > 100) { lstCommands.Items.RemoveAt(lstCommands.Items.Count - 1); }

            try
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));

                Socket client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                client.Connect(remoteEndPoint);
                client.Send(Encoding.ASCII.GetBytes(lstCommands.Items[0].ToString()));

                client.Close();
                client.Dispose();

                lstCommands.Items[0] = "[*] " + lstCommands.Items[0];
            }
            catch(Exception)
            {
                lstCommands.Items[0] = "[X] " + lstCommands.Items[0];
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Up,"+txtMoveAmount.Text);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Down," + txtMoveAmount.Text);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Left," + txtMoveAmount.Text);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Right," + txtMoveAmount.Text);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Forward," + txtMoveAmount.Text);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Backward," + txtMoveAmount.Text);
        }


        private void btnRotateForward_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Rotate,Forward," + txtRotateAmount.Text);
        }

        private void btnRotateBackward_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Rotate,Backward," + txtRotateAmount.Text);
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Rotate,CounterClockwise," + txtRotateAmount.Text);
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Rotate,Clockwise," + txtRotateAmount.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SendCommand(txtCharacterName.Text, "Delete");
        }

        private void btnCameraForward_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Forward," + txtMoveAmount.Text);
        }

        private void btnCameraBackward_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Backward," + txtMoveAmount.Text);
        }

        private void btnCameraLeft_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Left," + txtMoveAmount.Text);
        }

        private void btnCameraRight_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Right," + txtMoveAmount.Text);
        }

        private void btnCameraUp_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Up," + txtMoveAmount.Text);
        }

        private void btnCameraDown_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Down," + txtMoveAmount.Text);
        }

        private void btnCameraRotateForward_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Rotate,Forward," + txtRotateAmount.Text);
        }

        private void btnCameraRotateLeft_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Rotate,Left," + txtRotateAmount.Text);
        }

        private void btnCameraRotateRight_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Rotate,Right," + txtRotateAmount.Text);
        }

        private void btnCameraRotateBackward_Click(object sender, EventArgs e)
        {
            SendCommand("Camera", "Rotate,Backward," + txtRotateAmount.Text);
        }

        private void btnForward_Click_1(object sender, EventArgs e)
        {

        }
    }
}

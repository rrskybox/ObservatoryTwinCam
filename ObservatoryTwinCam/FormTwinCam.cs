using RtspClientSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;


namespace ObservatoryTwinCam
{
    public partial class FormTwinCam : Form
    {
        public string DeviceAddress1 { get; set; } = "192.168.1.145";
        public string Login1 { get; set; } = "admin";
        public string Password1 { get; set; } = "noburgersafter3";
        public string DeviceAddress2 { get; set; } = "192.168.1.139";
        public string Login2 { get; set; } = "admin";
        public string Password2 { get; set; } = "noburgersafter3";


        public FormTwinCam()
        {
            InitializeComponent();
            // Acquire the version information and put it in the form header
            try { this.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(); }
            catch { this.Text = " in Debug"; } //probably in debug, no version info available
            this.Text = "Observatory Twin Cam V" + this.Text;

            if (Properties.Settings.Default.Address1 != "")
                DeviceAddress1 = Properties.Settings.Default.Address1;
            else
                DeviceAddress1 = "192.168.1.1";

            if (Properties.Settings.Default.User1 != "")
                Login1 = Properties.Settings.Default.User1;
            else
                Login1 = "admin";

            if (Properties.Settings.Default.Password1 != "")
                Password1 = Properties.Settings.Default.Password1;
            else
                Password1 = "123456";

            if (Properties.Settings.Default.Address2 != "")
                DeviceAddress2 = Properties.Settings.Default.Address2;
            else
                DeviceAddress2 = "192.168.1.1";

            if (Properties.Settings.Default.User2 != "")
                Login2 = Properties.Settings.Default.User2;
            else
                Login2 = "admin";

            if (Properties.Settings.Default.Password2 != "")
                Password2 = Properties.Settings.Default.Password2;
            else
                Password2 = "123456";

            Camera1TextBox.Text = DeviceAddress1;
            User1TextBox.Text = Login1;
            Password1TextBox.Text = Password1;

            Camera2TextBox.Text = DeviceAddress2;
            User2TextBox.Text = Login2;
            Password2TextBox.Text = Password2;

            if (SceneControl.Lights(true, DeviceAddress1, Login1, Password1))
            {
                Light1Button.BackColor = Color.Orange;
                Light1Button.ForeColor = Color.Black;
                PlayOne();
            }

            if (SceneControl.Lights(true, DeviceAddress2, Login2, Password2))
            {
                Light2Button.BackColor = Color.Orange;
                Light2Button.ForeColor = Color.Black;
                PlayTwo();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayOne();
            PlayTwo();
        }

        private bool PlayOne()
        {
            string address1 = "rtsp://" + DeviceAddress1;
            var credential1 = new NetworkCredential(Login1, Password1);

            if (!Uri.TryCreate(address1, UriKind.Absolute, out Uri deviceUri1))
            {
                MessageBox.Show("Invalid device 1 address", "Error", MessageBoxButtons.OK);
                return false;
            }

            var connectionParameters1 = !string.IsNullOrEmpty(deviceUri1.UserInfo) ? new ConnectionParameters(deviceUri1) : new ConnectionParameters(deviceUri1, credential1);
            connectionParameters1.RtpTransport = RtpTransportProtocol.UDP;
            connectionParameters1.CancelTimeout = TimeSpan.FromSeconds(1);
            this.Camera1TextBox.Text = DeviceAddress1;
            this.User1TextBox.Text = Login1;
            this.Password1TextBox.Text = Password1;
            this.videoControl1.StartPlay(connectionParameters1);
            return true;
        }

        private bool PlayTwo()
        {
            string address2 = "rtsp://" + DeviceAddress2;
            var credential2 = new NetworkCredential(Login2, Password2);

            if (!Uri.TryCreate(address2, UriKind.Absolute, out Uri deviceUri2))
            {
                MessageBox.Show("Invalid device 2 address", "Error", MessageBoxButtons.OK);
                return false;
            }

            var connectionParameters2 = !string.IsNullOrEmpty(deviceUri2.UserInfo) ? new ConnectionParameters(deviceUri2) : new ConnectionParameters(deviceUri2, credential2);
            connectionParameters2.RtpTransport = RtpTransportProtocol.UDP;
            connectionParameters2.CancelTimeout = TimeSpan.FromSeconds(1);
            this.Camera2TextBox.Text = DeviceAddress2;
            this.User2TextBox.Text = Login2;
            this.Password2TextBox.Text = Password2;
            this.videoControl2.StartPlay(connectionParameters2);
            return true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SceneControl.Lights(false, DeviceAddress1, Login1, Password1);
            Light1Button.BackColor = Color.DarkGray;
            Light1Button.ForeColor = Color.White;
            this.videoControl1.Stop();
            SceneControl.Lights(false, DeviceAddress2, Login2, Password2);
            this.videoControl2.Stop();
            Light2Button.BackColor = Color.DarkGray;
            Light2Button.ForeColor = Color.White;
        }

        private void Light1Button_Click(object sender, EventArgs e)
        {
            if (Light1Button.BackColor == Color.DarkGray)
            {
                SceneControl.Lights(true, DeviceAddress1, Login1, Password1);
                Light1Button.BackColor = Color.Orange;
                Light1Button.ForeColor = Color.Black;
            }
            else
            {
                SceneControl.Lights(false, DeviceAddress1, Login1, Password1);
                Light1Button.BackColor = Color.DarkGray;
                Light1Button.ForeColor = Color.White;
            }
        }

        private void Light2Button_Click(object sender, EventArgs e)
        {
            if (Light2Button.BackColor == Color.DarkGray)
            {
                SceneControl.Lights(true, DeviceAddress2, Login2, Password2);
                Light2Button.BackColor = Color.Orange;
                Light2Button.ForeColor = Color.Black;
            }
            else
            {
                SceneControl.Lights(false, DeviceAddress2, Login2, Password2);
                Light2Button.BackColor = Color.DarkGray;
                Light2Button.ForeColor = Color.White;
            }

        }

        private void Up1Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Up, DeviceAddress1, Login1, Password1);
        }

        private void Down1Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Down, DeviceAddress1, Login1, Password1);
        }

        private void Left1Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Left, DeviceAddress1, Login1, Password1);
        }

        private void Right1Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Right, DeviceAddress1, Login1, Password1);
        }

        private void Up2Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Up, DeviceAddress2, Login2, Password2);
        }

        private void Left2Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Left, DeviceAddress2, Login2, Password2);
        }

        private void Right2Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Right, DeviceAddress2, Login2, Password2);
        }

        private void Down2Button_Click(object sender, EventArgs e)
        {
            SceneControl.MovePTZ(SceneControl.Direction.Down, DeviceAddress2, Login2, Password2);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            SceneControl.Lights(false, DeviceAddress1, Login1, Password1);
            this.videoControl1.Stop();
            SceneControl.Lights(false, DeviceAddress1, Login2, Password2);
            this.videoControl2.Stop();
            this.Close();
        }

        private void Camera1TextBox_TextChanged(object sender, EventArgs e)
        {
            DeviceAddress1 = Camera1TextBox.Text;
            Properties.Settings.Default.Address1 = DeviceAddress1;
            Properties.Settings.Default.Save();
        }

        private void User1TextBox_TextChanged(object sender, EventArgs e)
        {
            Login1 = User1TextBox.Text;
            Properties.Settings.Default.User1 = Login1;
            Properties.Settings.Default.Save();
        }

        private void Password1TextBox_TextChanged(object sender, EventArgs e)
        {
            Password1 = Password1TextBox.Text;
            Properties.Settings.Default.Password1 = Password1;
            Properties.Settings.Default.Save();
        }

        private void Camera2TextBox_TextChanged(object sender, EventArgs e)
        {
            DeviceAddress2 = Camera2TextBox.Text;
            Properties.Settings.Default.Address2 = DeviceAddress2;
            Properties.Settings.Default.Save();
        }

        private void User2TextBox_TextChanged(object sender, EventArgs e)
        {
            Login2 = User2TextBox.Text;
            Properties.Settings.Default.User2 = Login2;
            Properties.Settings.Default.Save();
        }

        private void Password2TextBox_TextChanged(object sender, EventArgs e)
        {
            Password2 = Password2TextBox.Text;
            Properties.Settings.Default.Password2 = Password2;
            Properties.Settings.Default.Save();
        }
    }
}

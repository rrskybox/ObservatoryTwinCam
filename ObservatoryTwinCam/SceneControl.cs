using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;
using RtspClientSharp;
using System.Threading;

using System.Windows.Forms;

namespace ObservatoryTwinCam
{
    public partial class SceneControl
    {
        //public string lightOff = @"http://192.168.1.145/cgi-bin/configManager.cgi?action=setConfig&Lighting[0][0].FarLight[0].Light=10&Lighting[0][0].NearLight[0].Light=90&Lighting[0][0].Mode=Off";
        //public string lightOn = @"http://192.168.1.145/cgi-bin/configManager.cgi?action=setConfig&Lighting[0][0].FarLight[0].Light=10&Lighting[0][0].NearLight[0].Light=90&Lighting[0][0].Mode=Manual";

        public static bool Lights(bool lightItUp, string address, string login, string password)
        {
            const string lightOff = @"/cgi-bin/configManager.cgi?action=setConfig&Lighting[0][0].FarLight[0].Light=10&Lighting[0][0].NearLight[0].Light=90&Lighting[0][0].Mode=Off";
            const string lightOn = @"/cgi-bin/configManager.cgi?action=setConfig&Lighting[0][0].FarLight[0].Light=10&Lighting[0][0].NearLight[0].Light=90&Lighting[0][0].Mode=Manual";

            var creds = new NetworkCredential() { UserName = login, Password = password };

            WebClient wbc = new WebClient();
            try
            {
                wbc.BaseAddress = "http://" + address;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            wbc.Credentials = creds;

            string resource;

            if (lightItUp)
                try { resource = wbc.DownloadString(lightOn); }
                catch { return false; }
            else
                try { resource = wbc.DownloadString(lightOff); }
                catch { return false; }

            wbc.Dispose();
            return true;
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        public static async void MovePTZ(Direction dir, string address, string login, string password)
        {
            StartPTZ(dir, address, login, password);
            Thread.Sleep(250);
            StopPTZ(dir, address, login, password);
        }

        private static async void StartPTZ(Direction dir, string address, string login, string password)
        {
            string startAction = @"/cgi-bin/ptz.cgi?action=start";
            string channel = "1";
            string direction = "Up";  //Default
            switch (dir)
            {
                case Direction.Up:
                    {
                        direction = "Up";
                        break;
                    }
                case Direction.Down:
                    {
                        direction = "Down";
                        break;
                    }
                case Direction.Left:
                    {
                        direction = "Left";
                        break;
                    }
                case Direction.Right:
                    {
                        direction = "Right";
                        break;
                    }
            }
            string arg1 = "0";
            string arg2 = "1";
            string arg3 = "0";
            // &channel=1&code=Up&arg1=0&arg2=1&arg3=0
            string urlStart = startAction + "&" + "channel=" + channel + "&code=" + direction + "&arg1=" + arg1 + "&arg2=" + arg2 + "&arg3=" + arg3;
            var creds = new NetworkCredential() { UserName = login, Password = password };

            WebClient wbc = new WebClient();
            wbc.BaseAddress = "http://" + address;
            wbc.Credentials = creds;

            string resource = wbc.DownloadString(urlStart);
            wbc.Dispose();
        }

        private static async void StopPTZ(Direction dir, string address, string login, string password)
        {
            string stopAction = @"/cgi-bin/ptz.cgi?action=stop";
            string channel = "1";
            string direction = "Up";  //Default
            switch (dir)
            {
                case Direction.Up:
                    {
                        direction = "Up";
                        break;
                    }
                case Direction.Down:
                    {
                        direction = "Down";
                        break;
                    }
                case Direction.Left:
                    {
                        direction = "Left";
                        break;
                    }
                case Direction.Right:
                    {
                        direction = "Right";
                        break;
                    }
            }
            string arg1 = "0";
            string arg2 = "0";
            string arg3 = "0";
            // &channel=1&code=Up&arg1=0&arg2=1&arg3=0
            string urlStop = stopAction + "&" + "channel=" + channel + "&code=" + direction + "&arg1=" + arg1 + "&arg2=" + arg2 + "&arg3=" + arg3;
            var creds = new NetworkCredential() { UserName = login, Password = password };

            WebClient wbc = new WebClient();
            wbc.BaseAddress = "http://" + address;
            wbc.Credentials = creds;

            string resource = wbc.DownloadString(urlStop);
            wbc.Dispose();
        }


    }
}

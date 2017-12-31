using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;
using SimpleWifi.Win32;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.IO;

namespace BuggyMapper
{
    public partial class UserControlConnect : UserControl
    {
        IEnumerable<AccessPoint> arrAP;
        public static String nodemcuIP = "";
        public static bool connectedToBuggy = false;

        public UserControlConnect()
        {
            arrAP = ClassWifi.FindAP();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var el in arrAP)
                listBox1.Items.Add(el.Name + "   " + el.SignalStrength + "db " + el.IsConnected);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            nodemcuIP = "http://192.168.4.1";

            ClassWifi.Connect(listBox1);
            System.Threading.Thread.Sleep(5000);
            listBox1.Items.Clear();
            foreach (var a in arrAP)
                listBox1.Items.Add(a.Name + " / " + a.SignalStrength + " / " + a.IsConnected);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (ClassWifi.wifi.ConnectionStatus.ToString() == "Connected")
            {
                ClassWifi.Disconnect();

                btnConnectToWiFi.Enabled = true;
                btnDisconnect.Enabled = false;
            }
        }

        private void UserControlConnect_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("User control home paint");

            Thread t = new Thread(checkIfConnectedToBuggy);
            t.Start();

            String connectionStatus = ClassWifi.wifi.ConnectionStatus.ToString();
            //Console.WriteLine(ClassWifi.wifi.ConnectionStatus);
            //labelConnectedToBuggy.Text = connectionStatus;

            /*
            //this is for wifi:
            if (connectionStatus == "Connected")
            {
                btnConnectToWiFi.Enabled = false;
                btnDisconnect.Enabled = true;
            }
            if (connectionStatus == "Disconnected")
            {
                btnConnectToWiFi.Enabled = true;
                btnDisconnect.Enabled = false;
            }
            */
        }
        
        private bool CheckForInternetConnection(String ip)
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead(ip))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void buttonConnectToBuggy_Click(object sender, EventArgs e)
        {
            connectToBuggy();
        }

        private void connectToBuggy()
        {
            if (!textBoxBuggyIP.Text.Contains("http://"))
            {

                if (this.textBoxBuggyIP.InvokeRequired)
                {
                    this.textBoxBuggyIP.BeginInvoke((MethodInvoker)delegate () {
                        textBoxBuggyIP.Text = "http://" + textBoxBuggyIP.Text;
                    });
                }
                else
                {
                    textBoxBuggyIP.Text = "http://" + textBoxBuggyIP.Text;
                }
            }
            nodemcuIP = textBoxBuggyIP.Text;
            Thread t = new Thread(checkIfConnectedToBuggy);
            t.Start();
        }

        private void checkIfConnectedToBuggy()
        {
            Thread.Sleep(200);
            if (CheckForInternetConnection(nodemcuIP))
            //if (requestWebpage(nodemcuIP) != "")
            {
                if (this.labelConnectedToBuggy.InvokeRequired)
                {
                    this.labelConnectedToBuggy.BeginInvoke((MethodInvoker)delegate () {
                        labelConnectedToBuggy.Text = "Connected";
                        labelConnectedToBuggy.ForeColor = Color.Green;
                    });
                }
            }
            else
            {
                if (this.labelConnectedToBuggy.InvokeRequired)
                {
                    this.labelConnectedToBuggy.BeginInvoke((MethodInvoker)delegate () {
                        labelConnectedToBuggy.Text = "Not connected";
                        labelConnectedToBuggy.ForeColor = Color.Red;
                    });
                }
            }
        }

        private void UserControlConnect_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonFindBuggy_Click(object sender, EventArgs e)
        {

            //String nodemcuIPtest1 = "http://192.168.1.";
            /*
            for(int i = 2; i < 15; i++)
            {
                Thread t = new Thread(() => requestWebpage(nodemcuIPtest1 + i));
                t.Start();
            }
            */

            Thread t = new Thread(findBuggyIP);
            t.Start();
        }
        
        private void findBuggyIP()
        {
            bool foundBuggy = false;
            int testIp = 1;
            while (!foundBuggy)
            {
                new Thread(() =>
                {
                    testIp++;
                    if (testIp > 32)
                    {
                        //TODO: uf there is no buggy connected to WiFi this will go to infinite loop
                    }
                    Thread.CurrentThread.IsBackground = true;
                    String nodemcuIPtest = "http://192.168.1." + testIp.ToString();
                    String response = requestWebpage(nodemcuIPtest);

                    if (response.Contains("Invalid request. Try:")) //TODO: change this
                    {
                        nodemcuIP = nodemcuIPtest;
                        foundBuggy = true;

                        if (this.textBoxBuggyIP.InvokeRequired)
                        {
                            this.labelConnectedToBuggy.BeginInvoke((MethodInvoker)delegate () {
                                textBoxBuggyIP.Text = nodemcuIP;

                                buttonConnectToBuggy.Enabled = false;
                            });
                        }
                        else
                        {
                            textBoxBuggyIP.Text = nodemcuIP;
                        }

                        connectToBuggy();
                    }
                }).Start();
            }
            
        }
        
        /*
        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        */

        private String requestWebpage(String url)
        {
            Console.WriteLine("requestWebpage " + url);
            using (var wb = new WebClient())
            {
                try
                {
                    String response = wb.DownloadString(url);
                    return response;
                }
                catch (Exception responseExc)
                {
                    //MessageBox.Show("I can't connect to Buggy!");
                    //Console.WriteLine(responseExc.Message);
                    //Console.WriteLine(responseExc.Source);
                    //Console.WriteLine(responseExc.StackTrace);
                    return "";
                }
            }
        }
    }
}

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

namespace BuggyApp
{
    public partial class UserControlConnect : UserControl
    {
        IEnumerable<AccessPoint> arrAP;
        static String nodemcuIP = "http://192.168.4.1";
        public UserControlConnect()
        {
            arrAP = ClassWifi.FindAP();
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (var el in arrAP)
                listBox1.Items.Add(el.Name + "   " + el.SignalStrength + "  " + el.IsConnected);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            ClassWifi.Connect(listBox1);
            System.Threading.Thread.Sleep(5000);
            listBox1.Items.Clear();
            foreach (var a in arrAP)
                listBox1.Items.Add(a.Name + " / " + a.SignalStrength + " / " + a.IsConnected);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
           ClassWifi.Disconnect();
        }
    }
}

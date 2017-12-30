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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            
            InitializeComponent();
            userControlHome1.BringToFront();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            userControlHome1.BringToFront();
          
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnConnect.Height;
            SidePanel.Top = btnConnect.Top;
            userControlConnect1.BringToFront();


        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnControls.Height;
            SidePanel.Top = btnControls.Top;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnInfo.Height;
            SidePanel.Top = btnInfo.Top;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void userControlConnect1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

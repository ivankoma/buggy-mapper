using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Threading;
using BuggyApp.Class;
using Newtonsoft.Json;
using static System.Windows.Forms.DataFormats;

namespace BuggyMapper
{
    public partial class UserControlControls : UserControl
    {
        public static Response r;
        public static Bitmap distanceMap;

        Thread readFromBuggyThread;
        int buggyDirection = 0; //0- up, 1-right, 2-down, 3-left

        public UserControlControls()
        {
            InitializeComponent();
        }

        private void UserControlControls_Load(object sender, EventArgs e)
        {
            distanceMap = new Bitmap(Config.mapSizeWidth, Config.mapSizeHeight);
            using (Graphics gfx = Graphics.FromImage(distanceMap))
                gfx.Clear(Color.White);

            distanceMap.SetPixel(Config.mapCenterX, Config.mapCenterY, Color.Green);
        }

        public static void go(String where)
        {
            //Console.WriteLine("Sending to nodemcu:/go/" + where);
            /*
            if (buggyDirection == 0)
                distanceColor = Color.Red;
            if (buggyDirection == 1)
                distanceColor = Color.Green;
            if (buggyDirection == 2)
                distanceColor = Color.Blue;
            if (buggyDirection == 3)
                distanceColor = Color.Black;
            */

            Stopwatch sw = new Stopwatch();
            sw.Start();
            String response = "";
            using (var wb = new WebClient())
            {
                try
                {
                    response = wb.DownloadString(UserControlConnect.nodemcuIP + where);
                }
                catch (Exception responseExc)
                {
                    //MessageBox.Show("I can't connect to Buggy!");
                    Console.WriteLine(responseExc.Message);
                    Console.WriteLine(responseExc.Source);
                    Console.WriteLine(responseExc.StackTrace);
                }
                sw.Stop();
                System.Diagnostics.Debug.WriteLine("request: " + where + " lag:" + sw.ElapsedMilliseconds + "ms");

            }
            //if (!response.Contains("ok"))
                //MessageBox.Show("No answer!");
        }

        bool readingFromBuggy = false;
        private Color distanceColor = Color.Black;

        private void checkBoxReadFromBuggy_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxReadFromBuggy.Checked)
            {
                if (readingFromBuggy == false)
                {
                    readingFromBuggy = true;
                    readFromBuggyThread = new Thread(readFromBuggy);
                    readFromBuggyThread.Start();
                }
            }
            else
            {
                readingFromBuggy = false;
                textBoxReadFromBuggy.Clear();
                readFromBuggyThread.Abort();
            }
        }

        void readFromBuggy()
        {
            while (readingFromBuggy)
            {
                using (var wb = new WebClient())
                {
                    String response = "-1";
                    try
                    {
                        response = wb.DownloadString(UserControlConnect.nodemcuIP + "/get");

                        if (this.textBoxReadFromBuggy.InvokeRequired)
                        {
                            this.textBoxReadFromBuggy.BeginInvoke((MethodInvoker)delegate ()
                            {
                                this.textBoxReadFromBuggy.Text = response;
                                parseBuggyResponse(response);
                            }
                            );
                        }
                        else
                        {
                            this.textBoxReadFromBuggy.Text = response;
                            parseBuggyResponse(response);
                        }
                    }
                    catch (Exception e) {
                        //MessageBox.Show("Can't read from buggy");
                    };
                    Thread.Sleep(500);
                }
            }
        }

        int returnValue(String response, String direction)
        {
            String temp = response.Substring(response.IndexOf(direction) + direction.Length + 1, 6);
            if(temp.Contains(" "))
            {
                temp = temp.Substring(0, temp.IndexOf(" "));
            }
            return Convert.ToInt32(Convert.ToDouble(temp));
        }

        int returnMeasurementError(double value)
        {
            int measurementError = Convert.ToInt32(Math.Tan(7.5 * Math.PI / 180.0) * value); //15 degrees is sensor's error
            measurementError *= 1; //just so it can be seen better
            return measurementError;
        }

        private void parseBuggyResponse(string response)
        {
            String value = "";
            int measurementError;
            if (!value.Contains("INF"))
            {
                using (Graphics gfx = Graphics.FromImage(distanceMap))
                    gfx.Clear(Color.White);

                int from = response.IndexOf("{");
                int to = response.IndexOf("}");
                response = response.Substring(from, to - from + 1);
                r = JsonConvert.DeserializeObject<Response>(response);
                
                measurementError = returnMeasurementError(r.sensorForward);
                for (int i = -(measurementError / 2); i < (measurementError / 2); i++)
                {
                    distanceMap.SetPixel(Config.mapCenterX + i, Config.mapCenterY - Convert.ToInt32(r.sensorForward), distanceColor);
                }

                
                measurementError = returnMeasurementError(r.sensorLeft);
                for (int i = -(measurementError / 2); i < (measurementError / 2); i++)
                {
                    distanceMap.SetPixel(Config.mapCenterX - Convert.ToInt32(r.sensorLeft), Config.mapCenterY + i, distanceColor);
                }


                measurementError = returnMeasurementError(r.sensorRight);
                for (int i = -(measurementError / 2); i < (measurementError / 2); i++)
                {
                    distanceMap.SetPixel(Config.mapCenterX + Convert.ToInt32(r.sensorRight), Config.mapCenterY + i, distanceColor);
                }

                
                ///Thread t = new Thread(() => addBitmapToPictureBox(pictureBoxMap, map));
                //t.Start();

                pictureBoxMap.Image = distanceMap; //TODO: fix this
            }
        }

        private void checkBoxReadFromBuggy_CheckedChanged(object sender, EventArgs e)
        {

        }
        //////////////////////////////////////////////////////////////////////////////////////
        private void buttonGoForward_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => go("/go/f" + textBoxGoForward.Text));
            t.Start();
        }

        private void buttonGoStop_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => go("/go/s"));
            t.Start();
        }

        private void buttonGoRight_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => go("/go/r" + textBoxGoRight.Text));
            t.Start();

            Image flipImage = pictureBoxDirection.Image;
            pictureBoxDirection.Image.RotateFlip(RotateFlipType.Rotate270FlipXY);
            pictureBoxDirection.Image = flipImage;

            buggyDirection++;
            if (buggyDirection == 4)
            {
                buggyDirection = 0;
            }
        }

        private void buttonGoLeft_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => go("/go/l" + textBoxGoLeft.Text));
            t.Start();

            Image flipImage = pictureBoxDirection.Image;
            pictureBoxDirection.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            pictureBoxDirection.Image = flipImage;
            
            buggyDirection--;
            if (buggyDirection == -1)
            {
                buggyDirection = 3;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        private void buttonReadFront_Click(object sender, EventArgs e)
        {
            //Thread frontThread = new Thread(() => readFromWeb(UserControlConnect.nodemcuIP + "/read/f"));
            //frontThread.Start();

            Thread t = new Thread(() => go("/read/f"));
            t.Start();
        }

        private void buttonReadLeft_Click(object sender, EventArgs e)
        {
            //Thread frontThread = new Thread(() => readFromWeb(UserControlConnect.nodemcuIP + "/read/l"));
            //frontThread.Start();

            Thread t = new Thread(() => go("/read/l"));
            t.Start();
        }

        private void buttonReadRight_Click(object sender, EventArgs e)
        {
            //Thread frontThread = new Thread(() => readFromWeb(UserControlConnect.nodemcuIP + "/read/r"));
            //frontThread.Start();

            Thread t = new Thread(() => go("/read/r"));
            t.Start();
        }
        /*
        private void readFromWeb(String url)
        {
            using (var wb = new WebClient())
            {
                try
                {
                    wb.DownloadString(url);
                }
                catch (Exception responseExc)
                {
                    MessageBox.Show(responseExc.Message);
                }
            }
        }
        */

        static public void addBitmapToPictureBox(PictureBox pb, Bitmap bitmap)
        {
            try
            {
                if (pb.InvokeRequired)
                {
                    pb.BeginInvoke((MethodInvoker)delegate ()
                    {
                        if (pb.Image != null)
                        {
                            pb.Image.Dispose();
                        }
                        pb.Image = bitmap;

                    });
                }
                else
                {
                    if (pb.Image != null)
                    {
                        pb.Image.Dispose();
                    }
                    pb.Image = bitmap;
                }
            }
            catch (Exception e) { };

            bitmap.Dispose();
        }

        private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlControls_Paint(object sender, PaintEventArgs e)
        {

        }

        public static Bitmap ResizeImage(System.Drawing.Bitmap imgToResize, Size size)
        {
            try
            {
                System.Drawing.Bitmap b = new System.Drawing.Bitmap(size.Width, size.Height);
                using (Graphics g = Graphics.FromImage((Image)b))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                    g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
                }
                return b;
            }
            catch
            {
                Console.WriteLine("Bitmap could not be resized");
                return imgToResize;
            }
        }

        private void UserControlControls_KeyDown(object sender, KeyEventArgs e)
        {/*
            Console.WriteLine("key down " + e.KeyCode);
            switch (e.KeyCode)
            {
                case Keys.Up:
                    go("f");
                    break;
                case Keys.Down:
                    go("s");
                    break;
                case Keys.Left:
                    go("l");
                    break;
                case Keys.Right:
                    go("r");
                    break;
            }
            */
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Right) || (keyData == Keys.Left) ||
                (keyData == Keys.Up) || (keyData == Keys.Down))
            {
                switch (keyData)
                {
                    case Keys.Up:
                        go("/go/f500");
                        break;
                    case Keys.Down:
                        go("/go/s");
                        break;
                    case Keys.Left:
                        go("/go/l300");
                        break;
                    case Keys.Right:
                        go("/go/r300");
                        break;
                }
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void buttonGoRightSoft_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => go("/go/r" + textBoxGoRightSoft.Text));
            t.Start();
        }

        private void buttonGoLeftSoft_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => go("/go/l" + textBoxGoLeftSoft.Text));
            t.Start();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Thread t = new Thread(() => go("/go/f550"));
                t.Start();
                Thread.Sleep(1500);
                go("/go/r9");
                Thread.Sleep(500);
            }

        }
    }
}

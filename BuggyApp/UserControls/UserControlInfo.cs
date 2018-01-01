using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuggyApp.Class;

namespace BuggyMapper
{
    public partial class UserControlInfo : UserControl
    {
        const string directionUP = "UP";
        const string directionDOWN = "DOWN";
        const string directionLEFT = "LEFT";
        const string directionRIGHT = "RIGHT";

        int realRobotLocationX, realRobotLocationY;
        List<Point> possibleLocations;
        List<Point> newPossibleLocations;
        Bitmap map;
        private int numberOfMeasurements = 0;

        public UserControlInfo()
        {
            InitializeComponent();
            possibleLocations = new List<Point>();
            newPossibleLocations = new List<Point>();
        }

        private void UserControlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlInfo_Load(object sender, EventArgs e)
        {
            map = new System.Drawing.Bitmap("map.png");
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, 3);
        }

        private void buttonReadTopSensor_Click(object sender, EventArgs e)
        {
            numberOfMeasurements++;
            int distance = 0;
            int currentX = realRobotLocationX;
            int currentY = realRobotLocationY;

            while(map.GetPixel(currentX, currentY) != Color.FromArgb(255, 0, 0, 0))
            {
                distance++;
                currentY--;
            }

            textBoxLog.Text += "Distance to the top wall:" + distance;
            addPossibleLocations(distance, directionUP);
        }

        private void buttonReadRightSensor_Click(object sender, EventArgs e)
        {
            numberOfMeasurements++;
            int distance = 0;
            int currentX = realRobotLocationX;
            int currentY = realRobotLocationY;

            while (map.GetPixel(currentX, currentY) != Color.FromArgb(255, 0, 0, 0))
            {
                distance++;
                currentX++;
            }

            textBoxLog.Text += "Distance to the right wall:" + distance;
            addPossibleLocations(distance, directionRIGHT);
        }

        private void buttonReadBottomSensor_Click(object sender, EventArgs e)
        {
            numberOfMeasurements++;
            int distance = 0;
            int currentX = realRobotLocationX;
            int currentY = realRobotLocationY;

            while (map.GetPixel(currentX, currentY) != Color.FromArgb(255, 0, 0, 0))
            {
                distance++;
                currentY++;
            }

            textBoxLog.Text += "Distance to the bottom wall:" + distance;
            addPossibleLocations(distance, directionDOWN);
        }

        private void buttonReadLeftSensor_Click(object sender, EventArgs e)
        {
            numberOfMeasurements++;
            int distance = 0;
            int currentX = realRobotLocationX;
            int currentY = realRobotLocationY;

            while (map.GetPixel(currentX, currentY) != Color.FromArgb(255, 0, 0, 0))
            {
                distance++;
                currentX--;
            }
            textBoxLog.Text += "Distance to the left wall:" + distance;
            addPossibleLocations(distance, directionLEFT);
        }

        private void buttonSetBuggyLocation_Click(object sender, EventArgs e)
        {
            try
            {
                map = new System.Drawing.Bitmap("map.png");
                realRobotLocationX = Int32.Parse(textBoxBuggyLocationX.Text);
                realRobotLocationY = Int32.Parse(textBoxBuggyLocationY.Text);
                Console.WriteLine(map.GetPixel(realRobotLocationX, realRobotLocationY));
                if (map.GetPixel(realRobotLocationX, realRobotLocationY) == Color.FromArgb(255,0,0,0))
                {
                    throw new Exception();
                }

                buttonReadLeftSensor.Enabled = true;
                buttonReadRightSensor.Enabled = true;
                buttonReadTopSensor.Enabled = true;
                buttonReadBottomSensor.Enabled = true;

                map.SetPixel(realRobotLocationX, realRobotLocationY, Color.FromArgb(255,0,255,0));
                graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, 3);

            }
            catch(Exception excParse)
            {
                MessageBox.Show("Use valid x and y values!");
            }
        }

        private void buttonDrawPossibleLocations_Click(object sender, EventArgs e)
        {

        }

        bool testLocation(int x, int y)
        {
            try
            {
                map.GetPixel(x, y);
            }catch(Exception boundsException)
            {
                return false;
            }
            return true;
        }

        void addPossibleLocations(int distance, String direction)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    //Console.WriteLine("({0},{1}",x,y);
                    bool possible = true;
                    int tempX, tempY;
                    for (int p = 0; p < distance; p++)
                    {
                        if (direction == directionUP)
                        {
                            tempX = x;
                            tempY = y - p;
                        }
                        else if (direction == directionDOWN)
                        {
                            tempX = x;
                            tempY = y + p;
                        }
                        else if (direction == directionLEFT)
                        {
                            tempX = x - p;
                            tempY = y;
                        }
                        else
                        {   //direction == directionRIGHT
                            tempX = x + p;
                            tempY = y;
                        }

                        if (!testLocation(tempX, tempY))
                            break;

                        if (map.GetPixel(tempX, tempY) == Color.FromArgb(255, 0, 0, 0))
                        {
                            possible = false;
                            break;
                        }
                    }
                    if (possible)
                    {
                        if (direction == directionUP)
                        {
                            tempX = x;
                            tempY = y - distance;
                        }
                        else if (direction == directionDOWN)
                        {
                            tempX = x;
                            tempY = y + distance;
                        }
                        else if (direction == directionLEFT)
                        {
                            tempX = x - distance;
                            tempY = y;
                        }
                        else
                        {   //direction == directionRIGHT
                            tempX = x + distance;
                            tempY = y;
                        }
                        if (!testLocation(tempX, tempY))
                            break;

                        if (map.GetPixel(tempX, tempY) != Color.FromArgb(255, 0, 0, 0))
                        {
                            possible = false;
                        }
                        if (possible)
                        {
                            if (numberOfMeasurements == 1)
                            {
                                possibleLocations.Add(new Point(x, y));
                            }
                            else
                            {
                                if(possibleLocations.Contains(new Point(x, y))){ 
                                    newPossibleLocations.Add(new Point(x, y));
                                    //possibleLocations.Remove(new Point(x, y));
                                }
                            }

                            if (direction == directionUP)
                                map.SetPixel(x, y, Color.Orange);
                            if (direction == directionDOWN)
                                map.SetPixel(x, y, Color.Purple);
                            if (direction == directionLEFT)
                                map.SetPixel(x, y, Color.Red);
                            if (direction == directionRIGHT)
                                map.SetPixel(x, y, Color.Pink);
                        }
                    }
                }
            }

            if (newPossibleLocations.Count >= 1)
            {
                possibleLocations.Clear();
                possibleLocations = newPossibleLocations.ToList();
                newPossibleLocations.Clear();
            }
            Console.WriteLine("Possible locations:");
            textBoxLog.Text += "\r\nPossible locations:\r\n";
            String log = "";
            foreach (var p in possibleLocations)
            {
                log += p + "\r\n";
            }
            Console.WriteLine(log);
            textBoxLog.Text += log;


            Console.WriteLine("---------------------------");
            if(possibleLocations.Count == 1)
            {
                map = new System.Drawing.Bitmap("map.png");
                map.SetPixel(possibleLocations[0].X, possibleLocations[0].Y, Color.FromArgb(255,0,255,0));
                MessageBox.Show("Found buggy", possibleLocations[0].X.ToString() +"," + possibleLocations[0].Y.ToString());

                possibleLocations.Clear();
                newPossibleLocations.Clear();
                numberOfMeasurements = 0;
            }
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, 3);
        }
    }
}

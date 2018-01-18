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
using System.Diagnostics;
using System.Threading;

namespace BuggyApp.UserControls
{
    public partial class UserControlPathfinding : UserControl
    {
        static Bitmap map;
        static int MAP_SCALE = 5;
        static Point start = new Point(-1, -1);
        static Point goal = new Point(-1, -1);
        int definedPoints = 0;
        int BUGGY_SAFE_SIZE = 9; //176 diagonal in mm
        String MAP = "map.png";
        List<Point> safeAreas;

        public UserControlPathfinding()
        {
            InitializeComponent();
            safeAreas = new List<Point>();
        }

        private void UserControlPathfinding_Load(object sender, EventArgs e)
        {
            map = new System.Drawing.Bitmap(MAP);
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }

        private void buttonGenerateMap_Click(object sender, EventArgs e)
        {
            previousPath.Clear();

            map = new System.Drawing.Bitmap(MAP);

            using (Graphics gfx = Graphics.FromImage(map))
            using (SolidBrush brushObject = new SolidBrush(Color.Black))
            {
                Random rnd = new Random();
                for (int i = 0; i < map.Width / 20; i++)
                {
                    gfx.FillRectangle(brushObject, rnd.Next(0, map.Width), rnd.Next(0, map.Height), rnd.Next(5, map.Height / 5), rnd.Next(5, map.Width / 5));
                    gfx.FillEllipse(brushObject, rnd.Next(0, map.Width), rnd.Next(0, map.Height), rnd.Next(5, map.Height / 5), rnd.Next(5, map.Width / 5));
                }
            }

            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            map = new System.Drawing.Bitmap(MAP);

            definedPoints = 0;
            if(start.X != 0 && start.Y != 0)
                map.SetPixel(start.X, start.Y, Color.White);

            if (goal.X != 0 && goal.Y != 0)
                map.SetPixel(goal.X, goal.Y, Color.White);

            start = new Point(-1, -1);
            goal = new Point(-1, -1);

            previousPath.Clear();
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }

        
        private void buttonGenerateSafeAreas_Click(object sender, EventArgs e)
        {
            map = GenerateSafeAreas();
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }

        private Bitmap GenerateSafeAreas()
        {
            Bitmap temp = map.Clone(new Rectangle(0, 0, map.Width, map.Height), map.PixelFormat);

            using (Graphics gfx = Graphics.FromImage(temp))
            using (SolidBrush brushObject = new SolidBrush(Color.FromArgb(255, 128, 128, 128)))
            {
                for (int y = 0; y < map.Height; y++)
                {
                    for (int x = 0; x < map.Width; x++)
                    {
                        var pixel = map.GetPixel(x, y);
                        if (pixel == Color.FromArgb(255, 0, 0, 0))
                        {
                            gfx.FillRectangle(brushObject, x - BUGGY_SAFE_SIZE / 2, y - BUGGY_SAFE_SIZE / 2, BUGGY_SAFE_SIZE, BUGGY_SAFE_SIZE);
                        }
                    }
                }
            }

            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    if (map.GetPixel(x, y) == Color.FromArgb(255, 0, 0, 0))
                    {
                        temp.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                    }
                }
            }

            return temp;
        }

        bool testLocation(Bitmap bmp, int x, int y)
        {
            try
            {
                if( bmp.GetPixel(x, y) == Color.FromArgb(255, 0, 0, 0) ||
                    bmp.GetPixel(x, y) == Color.FromArgb(255, 128, 128, 128))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception boundsException)
            {
                return false;
            }
        }

        bool DEBUG = false;
        bool DIAGONAL = false;
        
        List<Point> previousPath = new List<Point>();
        private void buttonFindPath_Click(object sender, EventArgs e)
        {             
            Thread t = new Thread(() =>
            {
                FindPath();
            });
            t.Start();
            Console.WriteLine("KRAJ");
        }

        private void FindPath()
        {
            ColorPath(previousPath, Color.White);
            List<Point> frontier = new List<Point>();
            frontier.Add(start);

            Dictionary<Point, Point> came_from = new Dictionary<Point, Point>();
            //came_from.Add(start, start);

            came_from = VisitAllNodes(frontier, came_from);

            List<Point> path = GetPathFromCurrentToGoal(came_from, goal, start);

            previousPath = path;

            ComposePathCommand(path);

            Thread.Sleep(100);
            ColorPath(path, Color.Lime);
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }

        private void ColorPath(List<Point> path, Color color)
        {
            foreach (var p in path)
            {
                map.SetPixel(p.X, p.Y, color);
            }
        }

        private List<Point> GetPathFromCurrentToGoal(Dictionary<Point, Point> came_from, Point current, Point start)
        {
            List<Point> path = new List<Point>();
            Point came_from_point;

            while (current != start)
            {
                path.Add(current);
                came_from.TryGetValue(current, out came_from_point);
                current = came_from_point;
            }
            path.Add(start);
            path.Reverse();
            return path;
        }

        private Dictionary<Point, Point> VisitAllNodes(List<Point> frontier, Dictionary<Point, Point> came_from)
        {
            Point current;
            while (frontier.Count != 0)                             //while not frontier.empty():
            {
                //current = frontier[frontier.Count - 1];           //current = frontier.get()
                current = frontier[0];
                var neighbors = graphNeighbors(current);
                foreach (var next in neighbors)       //for next in graph.neighbors(current):
                {
                    if (!came_from.ContainsKey(next))
                    {
                        frontier.Add(next);                         //frontier.put(next)
                        came_from.Add(next, current);

                        if (DEBUG)
                        {
                            Thread.Sleep(10);
                            Console.WriteLine(next + " came from " + current);
                            map.SetPixel(next.X, next.Y, Color.GreenYellow);
                            map.SetPixel(current.X, current.Y, Color.Brown);
                            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
                        }
                    }
                }
                frontier.Remove(current);
            };
            return came_from;
        }

        private Point DifferenceBetweenTwoPoints(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        private String DifferenceToCommand(Point p)
        {
            Point left  = new Point(-1, 0);
            Point right = new Point(+1, 0);
            Point up    = new Point(0, -1);
            Point down  = new Point(0, +1);

            Point leftUp = new Point(-1, -1);
            Point rightUp = new Point(+1, -1);
            Point leftDown = new Point(-1, +1);
            Point rightDown = new Point(+1, +1);
            if (p == left)
                return "L";
            else if (p == right)
                return "R";
            else if (p == up)
                return "U";
            else if(p == down)
                return "D";
            else if(p == leftUp)
                return "LU";
            else if(p == leftDown)
                return "LD";
            else if(p == rightUp)
                return "RU";
            else if(p == rightDown)
                return "RD";

            return "-";
        }

        private void ComposePathCommand(List<Point> path)
        {
            String pathCommand = "";
            int numberOfSteps = 1;
            int pathLength = 0;
            Point previousDifference = new Point(0, 0);
            for(int i=1;i<path.Count;i++)
            {
                Point difference = DifferenceBetweenTwoPoints(path[i], path[i - 1]);
                
                if(difference != previousDifference)
                {
                    pathCommand += numberOfSteps + ";" + DifferenceToCommand(difference);
                    //Console.Write(numberOfSteps);
                    //Console.WriteLine(DifferenceToCommand(difference));

                    previousDifference = difference;
                    numberOfSteps = 1;
                }
                else
                {
                    numberOfSteps++;
                    pathLength++;
                }   
            }
            pathCommand += numberOfSteps;
            pathCommand = pathCommand.Substring(pathCommand.IndexOf(";") + 1);
            Console.WriteLine("pathCommand: " + pathCommand);
            Console.WriteLine("pathLength" + pathLength);

            Console.WriteLine(pathCommand);
        }


        private List<Point> graphNeighbors(Point center)
        {
            List<Point> locations = new List<Point>();

            locations.Add(new Point(-1, 0));
            locations.Add(new Point(+1, 0));
            locations.Add(new Point(0, +1));
            locations.Add(new Point(0, -1));

            locations.Reverse();    //daleko manje skretanja

            if (DIAGONAL)
            {
                locations.Add(new Point(-1, -1));
                locations.Add(new Point(+1, +1));
                locations.Add(new Point(+1, -1));
                locations.Add(new Point(-1, +1));
            }

            List<Point> neighbors = new List<Point>();

            foreach(Point l in locations)
            {
                int tempX = center.X + l.X;
                int tempY = center.Y + l.Y;
                if(testLocation(map, tempX, tempY))
                {
                    neighbors.Add(new Point(tempX, tempY));
                }
            }
            //printList(center + " neighbors:", neighbors);
            return neighbors;
        }

        private void printList(String text, List<Point> list)
        {
            Console.WriteLine(text);
            foreach(var l in list)
            {
                Console.WriteLine(l.ToString());
            }
        }

        private void checkBoxDiagonal_CheckedChanged(object sender, EventArgs e)
        {
            DIAGONAL = checkBoxDiagonal.Checked;
        }

        private void pictureBoxMap_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int mapx = coordinates.X / MAP_SCALE;
            int mapy = coordinates.Y / MAP_SCALE;

            start = new Point(mapx, mapy);
            
            if(start != new Point(-1, -1) && goal != new Point(-1, -1) && map.GetPixel(mapx, mapy) == Color.FromArgb(255, 255, 255, 255))
            {
                FindPath();
            }   
            */
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            definedPoints++;

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            int mapx = coordinates.X / MAP_SCALE;
            int mapy = coordinates.Y / MAP_SCALE;
            Console.WriteLine(mapx + "," + mapy + " " + map.GetPixel(mapx, mapy));

            ColorPath(previousPath, Color.White);

            if (definedPoints == 1)
            {
                /*
                if(start != new Point(-1, -1))
                {
                    drawBuggy(start, Color.White, Color.White);
                }
                */

                if (goal != new Point(-1, -1))
                {
                    map.SetPixel(goal.X, goal.Y, Color.White);
                }


                start = new Point(mapx, mapy);
                map.SetPixel(mapx, mapy, Color.Red);
            }
            else if (definedPoints == 2)
            {
                goal = new Point(mapx, mapy);
                map.SetPixel(mapx, mapy, Color.Blue);

                definedPoints = 0;

                Console.WriteLine("start: " + start);
                Console.WriteLine("goal: " + goal);

                FindPath();
            }

            //drawBuggy(start, Color.Green, Color.Lime);

            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }

        private void drawBuggy(Point buggyLocation, Color primary, Color center)
        {
            using (Graphics gfx = Graphics.FromImage(map))
            using (SolidBrush brushObject = new SolidBrush(primary))
            {
                gfx.FillRectangle(brushObject, buggyLocation.X - BUGGY_SAFE_SIZE / 2, buggyLocation.Y - BUGGY_SAFE_SIZE / 2, BUGGY_SAFE_SIZE, BUGGY_SAFE_SIZE);      
            }
            map.SetPixel(buggyLocation.X, buggyLocation.Y, center);
            graphicalOperations.AddBitmapToPictureBox(pictureBoxMap, map, MAP_SCALE);
        }
    }
}

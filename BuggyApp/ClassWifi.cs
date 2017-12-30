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

namespace BuggyApp
{
    public static class ClassWifi
    {
        public static Wifi wifi = new Wifi();
        public static void Disconnect()
        {
            wifi.Disconnect();
        }

        public static IEnumerable<AccessPoint> FindAP()
        {
            IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);
            return accessPoints;
        }
        public static void Connect(ListBox a)
        {
            var accessPoints = FindAP();
            int selectedIndex = a.SelectedIndex;
            if (selectedIndex > accessPoints.ToArray().Length || accessPoints.ToArray().Length == 0)
            {
                Console.Write("\r\nIndex out of bounds");
                return;
            }
            AccessPoint selectedAP = accessPoints.ToList()[selectedIndex]; 
            AuthRequest authRequest = new AuthRequest(selectedAP);
            bool overwrite = true;

            if (authRequest.IsPasswordRequired)
            {
                if (selectedAP.HasProfile)
                // If there already is a stored profile for the network, we can either use it or overwrite it with a new password.
                {
                    Console.Write("\r\nA network profile already exist, do you want to use it (y/n)? ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        overwrite = false;
                    }
                }

                if (overwrite)
                {
                    if (authRequest.IsUsernameRequired)
                    {
                        //   Console.Write("\r\nPlease enter a username: ");
                        //   MessageBox.Show("\r\nPlease enter a username: ");
                        authRequest.Username = Console.ReadLine();
                    }

                    authRequest.Password = PasswordPrompt(selectedAP);

                    if (authRequest.IsDomainSupported)
                    {
                        // Console.Write("\r\nPlease enter a domain: ");
          //              MessageBox.Show("\r\nPlease enter a domain: ");
                        authRequest.Domain = Console.ReadLine();
                    }
                }
            }

            selectedAP.ConnectAsync(authRequest, overwrite, OnConnectedComplete);
        }

        private static string PasswordPrompt(AccessPoint selectedAP)
        {
            string password = string.Empty;

            bool validPassFormat = false;

            while (!validPassFormat)
            {
                // Console.Write("\r\nPlease enter the wifi password: ");
            //    MessageBox.Show("\r\nPlease enter wifi password: ");
                password = Console.ReadLine();

                validPassFormat = selectedAP.IsValidPassword(password);

                if (!validPassFormat)
              //      MessageBox.Show("\r\nPassword is not valid for this network type.");
                   Console.WriteLine("\r\nPassword is not valid for this network type.");
            }

            return password;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

        private static void Status()
        {
            Console.WriteLine("\r\n-- CONNECTION STATUS --");
            if (wifi.ConnectionStatus == WifiStatus.Connected)
                //  Console.WriteLine("You are connected to a wifi");
                MessageBox.Show("You are connected to a wifi");
            else
                MessageBox.Show("You are not connected to a wifi");
            // Console.WriteLine("You are not connected to a wifi");

        }

        private static void ProfileXML()
        {
            var accessPoints = FindAP();

            Console.Write("\r\nEnter the index of the network you wish to print XML for: ");

            int selectedIndex = int.Parse(Console.ReadLine());
            if (selectedIndex > accessPoints.ToArray().Length || accessPoints.ToArray().Length == 0)
            {
                Console.Write("\r\nIndex out of bounds");
                return;
            }
            AccessPoint selectedAP = accessPoints.ToList()[selectedIndex];

            Console.WriteLine("\r\n{0}\r\n", selectedAP.GetProfileXML());
        }

        private static void DeleteProfile()
        {
            var accessPoints = FindAP();

            Console.Write("\r\nEnter the index of the network you wish to delete the profile: ");

            int selectedIndex = int.Parse(Console.ReadLine());
            if (selectedIndex > accessPoints.ToArray().Length || accessPoints.ToArray().Length == 0)
            {
                Console.Write("\r\nIndex out of bounds");
                return;
            }
            AccessPoint selectedAP = accessPoints.ToList()[selectedIndex];

            selectedAP.DeleteProfile();
            Console.WriteLine("\r\nDeleted profile for: {0}\r\n", selectedAP.Name);
        }


        private static void ShowInfo()
        {
            var accessPoints = FindAP();

            Console.Write("\r\nEnter the index of the network you wish to see info about: ");

            int selectedIndex = int.Parse(Console.ReadLine());
            if (selectedIndex > accessPoints.ToArray().Length || accessPoints.ToArray().Length == 0)
            {
                Console.Write("\r\nIndex out of bounds");
                return;
            }
            AccessPoint selectedAP = accessPoints.ToList()[selectedIndex];

            Console.WriteLine("\r\n{0}\r\n", selectedAP.ToString());
        }

        private static void wifi_ConnectionStatusChanged(object sender, WifiStatusEventArgs e)
        {
            Console.WriteLine("\nNew status: {0}", e.NewStatus.ToString());
        }

        private static void OnConnectedComplete(bool success)
        {
            Console.WriteLine("\nOnConnectedComplete, success: {0}", success);
        }
    }
}
  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Utils; // my utilities function
/*
so up above are just stuff to make things easier i tink
but thats cool so im happi
 */
// i mostly know lua so i want to make coding easier
// this is written day 1, uploaded 3:25 pm mdt
// 9/6/25
namespace Main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string Username = null;
            string Password = null;
            bool signedIn = false;
            string exePath = Assembly.GetExecutingAssembly().Location;

            Shortcuts.print("Hello!");

            string accountsFolder = Path.Combine(Path.GetDirectoryName(exePath), "Accounts");
            string configFile = Path.Combine(accountsFolder, "config.txt");
            if (!Directory.Exists(accountsFolder))
            {
                Directory.CreateDirectory(accountsFolder);
            }
            if (Directory.Exists(accountsFolder) && File.Exists(configFile))
            {
                string filedata = File.ReadAllText(configFile);
                if (filedata.Contains("signedIn = True")) // checks if you ever signed in
                {
                    signedIn = true;
                }
            }
            if (!signedIn)
            {
                Shortcuts.print("Enter Username:");
                Username = (string)Shortcuts.Readln();
                Shortcuts.print("Enter Password:");
                Password = (string)Shortcuts.Readln();
                Shortcuts.WriteConfig(configFile, Username, Password, true);
            } else
            {
                Shortcuts.print("You are signed in.");
                Shortcuts.print("Sign out?");
                string Data = (string)Shortcuts.Readln();
                if (Data == "Yes")
                {
                    
                    signedIn = false;
                    Shortcuts.WriteConfig(configFile, Username, Password, false);
                }
            }
        }
    }
}

using System;
using System.IO;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Threading;
using Utils;

// 9/16/25
// Last updated: 12:06 AM

namespace Main
{
    internal class Program
    {
        static void FirstMethod()
        {
            Console.WriteLine("First ever method i've wrote"); // almost forgot the ; here ._.
        }
        class uhh
        {
        uhh myObj = new uhh(); // i do not fucking understand this. im a roblox lua dev not a C# dev (but i should learn it)
        }
        static void Main(string[] args)
        {
            string Username = null; // i KNOW WHAT NULL IS! YEAAAA
            string Password = null; // null.
            bool signedIn = false; // you are not signed in.
            string exePath = Assembly.GetExecutingAssembly().Location; // idk why i called it an exe its a .cs lol

            Shortcuts.print("Hello!"); // hi
            FirstMethod(); // i figured tis out

            string accountsFolder = Path.Combine(Path.GetDirectoryName(exePath), "Accounts"); // im not sure how this is secure
            string configFile = Path.Combine(accountsFolder, "config.txt"); // took a while as well

            if (!Directory.Exists(accountsFolder)) // this took an hour to figure out on my own
            {
                Directory.CreateDirectory(accountsFolder); // if no accounts then make accounts
            }

            if (File.Exists(configFile))
            {
                string filedata = File.ReadAllText(configFile);
                if (filedata.Contains("signedIn = True")) // checks if you ever signed in
                {
                    signedIn = true; // you are signed in.
                }
            }

            if (!signedIn) // i learned how to use ! from just other code lol, its funny how i learn
            {
                Shortcuts.print("Enter Username:"); // you should totally put "skibiditoilet696942067tralalerotralala"
                Username = (string)Shortcuts.Readln();
                Shortcuts.print("Enter Password:"); // put 1234, i dare you
                Password = (string)Shortcuts.Readln();
                Shortcuts.WriteConfig(configFile, Username, Password, true); // i didnt wan write over and over
            }
            else
            {
                Shortcuts.print("You are signed in."); // good boy

                Shortcuts.print("Sign out?"); // dont.
                string Data = (string)Shortcuts.Readln();
                if (Data.ToLower() == "yes") // YOU MONKEY
                {
                    signedIn = false; // you are not signed in.
                    Shortcuts.WriteConfig(configFile, Username, Password, false); // again
                }
            }
        }
    }
}
// this app is mostly just a test app. dont take my comments seriously
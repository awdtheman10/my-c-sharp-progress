using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// 9/16/25
// Last updated: 12:12 AM



namespace Utils
{
    internal class Shortcuts
    {
        public static void print(string message) {
            Console.WriteLine(message); // right now this is basic, but it works for now
        }
        public static Object SetValue(Object Value, Object newValue) // why did i make this
        {
            return newValue; 
        }
        public static Object GetValue(Object thingy) { // again, why DID I MAKE THIS??
            return thingy; 
        }
        public static Object Readln() // this is stupid
        {
            string Line = Console.ReadLine();
            return Line;
        }
        public static System.IO.FileInfo CreateFile(string path, string data, string name) // this is better to use when creating the file than writefile, as they do the same thing, but this can have a name.
        {
            System.IO.File.WriteAllText((path + name), data);
            return new System.IO.FileInfo(path + name);
        } // this js makes a file
        public static void DeleteFile(string path) // why is this even here
        {
            System.IO.File.Delete(path); // deletes the file
        }
        public static void WriteFile(string path, string data) // dont use this unless you want to WRITE TO A FILE. 
        {
            System.IO.File.WriteAllText(path, data); // can be used instead of create file, but createfile is better
        }
        public static void WriteConfig(string path, string Username, string Password, bool SignedIn)
        {
            string FileData = "{" +
                        " signedIn = " + SignedIn +
                        " username: " + Username +
                        " password: " + Password +
                        "}"; // so basic ik ik. no IT IS NOT JSON. IT IS SIMPLY MY OWN FORMAT I WANT (but its basically json so WHO CARES)
            WriteFile(path, FileData);
        } // writes the config needed
        public static void PlaySound(int frequency, int duration) // WHY??? WHY DID I MAKE THIS
        {
            Console.Beep(frequency, duration);
        } // idk why this is here, but it is lol

    }
}

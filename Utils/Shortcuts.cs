using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
// 9/6/25
// 3:16 PM MDT Last updated
namespace Utils
{
    internal class Shortcuts
    {
        public static void print(string message) {
            Console.WriteLine(message); // right now this is basic, but it works for now
        }
        public static Object SetValue(Object Value, Object newValue)
        {
            return newValue;
        }
        public static Object GetValue(Object thingy) {
            return thingy; 
        }
        public static Object Readln()
        {
            string Line = Console.ReadLine();
            return Line;
        }
        public static System.IO.FileInfo CreateFile(string path, string data, string name) // this is better to use when creating the file than writefile, as they do the same thing, but this can have a name.
        {
            System.IO.File.WriteAllText((path + name), data);
            return new System.IO.FileInfo(path);
        } // this js makes a file
        public static void DeleteFile(string path)
        {
            System.IO.File.Delete(path); // deletes the file
        }
        public static void WriteFile(string path, string data)
        {
            System.IO.File.WriteAllText(path, data); // can be used instead of create file, but createfile is better
        }
        public static void WriteConfig(string path, string Username, string Password, bool SignedIn)
        {
            string FileData = "{" +
                        " signedIn = " + SignedIn +
                        " username: " + Username +
                        " password: " + Password +
                        "}";
            WriteFile(path, FileData);
        }
    }
}

using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyConsoleApp.LoggerClass
{
    public class FileSystemLogger : ILogger
    {
        public void LogMsg(string msg)
        {
            if (File.Exists("Log.txt"))
            {
                StreamWriter sw = File.AppendText("Log.txt");
                sw.WriteLine(msg);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("Log.txt");
                sw.WriteLine(msg);
                sw.Close();
            }            
        }
    }
}

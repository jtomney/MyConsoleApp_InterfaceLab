using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyConsoleApp.LoggerClass
{
    class FileSystemLogger : ILogger
    {
        void ILogger.LogMsg(string msg)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Kimba\\Documents\\Log.txt");
            sw.WriteLine(msg);            
            sw.Close();
        }
    }
}

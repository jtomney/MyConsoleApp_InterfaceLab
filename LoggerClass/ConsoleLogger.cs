using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.LoggerClass
{
    public class ConsoleLogger : ILogger
    {
        public void LogMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

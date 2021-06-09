using MyConsoleApp.Interfaces;
using MyConsoleApp.LoggerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace MyConsoleApp
{
    public class Program
    {
        private static ILogger _logger;

        static void Main(string[] args)
        {
            ComposeApp();
            _logger.LogMsg("Hello World");
            WaitToExit();
        }

        private static void ComposeApp()
        {
            string loggerType = ConfigurationManager.AppSettings.Get("Logger");

            if (loggerType == "ConsoleLogger")
            {
                ConsoleLogger logger = new ConsoleLogger();
                _logger = logger;
            }
            else
            {
                FileSystemLogger logger = new FileSystemLogger();
                _logger = logger;
            }
        }

        private static void WaitToExit()
        {
            Console.WriteLine("All done, you can exit now");
            Console.ReadLine();
        }
    }
}

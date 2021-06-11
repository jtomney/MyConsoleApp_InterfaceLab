using MyConsoleApp.Interfaces;
using MyConsoleApp.LoggerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using MyConsoleApp.UniqueFilenameClass;

namespace MyConsoleApp
{
    public class Program
    {
        private static ILogger _logger;
        private static IArguments _arguments;
        private static IUniqueFilename _uniqueFilename;

        static void Main(string[] args)
        {
            ComposeApp();
            _logger.LogMsg("Kimball plugin initialized");
            var argsList = _arguments.ParseArguments(args);
            _uniqueFilename.LogUniqueFilename(argsList);   
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

            Arguments arguments = new Arguments();
            UniqueFilename uniqueFilename = new UniqueFilename(_logger);

            _arguments = arguments;
            _uniqueFilename = uniqueFilename;
        }

        private static void WaitToExit()
        {
            Console.WriteLine("All done, you can exit now");
            Console.ReadLine();
        }
    }
}

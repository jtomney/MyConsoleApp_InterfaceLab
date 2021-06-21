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
using MyConsoleApp.OutputFileClass;

namespace MyConsoleApp
{
    public class Program
    {
        private static ILogger _logger;
        private static ICommandLineArgsParser _arguments;        
        private static IDciFilenameGenerator _uniqueFilename;
        private static IOutputFilenameGenerator _outputFilename;
        private static IOutputFileGenerator _outputFile;

        static void Main(string[] args)
        {
            ComposeApp();
            _logger.LogMsg("Kimball plugin initialized");
            var argsList = _arguments.ParseCmdLineArgsToSrvNmAppIdDTOs(args);
            _uniqueFilename.LogUniqueDciFilename(argsList);   
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

            CommandLineArgsParser arguments = new CommandLineArgsParser();
            _arguments = arguments;

            OutputFilenameGenerator outputFilename = new OutputFilenameGenerator();
            _outputFilename = outputFilename;

            OutputFileGenerator outputFile = new OutputFileGenerator(_outputFilename);
            _outputFile = outputFile;

            DciFilenameGenerator uniqueFilename = new DciFilenameGenerator(_logger, _outputFile);                       
            _uniqueFilename = uniqueFilename;
        }

        private static void WaitToExit()
        {
            Console.WriteLine("All done, you can exit now");
            Console.ReadLine();
        }
    }
}

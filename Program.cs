using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        private static void WaitToExit()
        {
            Console.WriteLine("All done, you can exit now");
            Console.ReadLine();
        }
    }
}

using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.OutputFileClass
{
    public class OutputFilenameGenerator : IOutputFilenameGenerator
    {
        public string GenerateDciOutputFilename()
        {
            DateTime timestamp = DateTime.Now;            
            string timestampStr = timestamp.ToString("yyyyMMddHHmmss");

            return "GeneratedDCI." + timestampStr + ".txt";
        }
    }
}

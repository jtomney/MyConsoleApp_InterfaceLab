using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.OutputFileClass
{
    public class OutputFileGenerator : IOutputFileGenerator
    {
        private readonly IOutputFilenameGenerator _outputFilename;
        public OutputFileGenerator(IOutputFilenameGenerator outputFilename)
        {
            _outputFilename = outputFilename;
        }
        public void WriteUniqueDciFilenameToFile(string dciFilename)
        {
            var outputFilename = _outputFilename.GenerateDciOutputFilename();

            if (File.Exists(outputFilename))
            {
                StreamWriter sw = File.AppendText(outputFilename);
                sw.WriteLine(dciFilename);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(outputFilename);
                sw.WriteLine(dciFilename);
                sw.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Interfaces
{
    public interface IOutputFileGenerator
    {
        void WriteUniqueDciFilenameToFile(string dciFilename);
    }
}

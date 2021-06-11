using MyConsoleApp.UniqueFilenameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Interfaces
{
    public interface IArguments
    {
        List<ArgumentsDto> ParseArguments(string[] args);
    }
}

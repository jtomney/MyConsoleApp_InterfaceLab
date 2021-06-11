using MyConsoleApp.UniqueFilenameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Interfaces
{
    public interface IUniqueFilename
    {
        void LogUniqueFilename(List<ArgumentsDto> args);
        string GenerateUniqueFilename(string serverName, string appId);        
    }
}

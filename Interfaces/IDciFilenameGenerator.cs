using MyConsoleApp.UniqueFilenameClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.Interfaces
{
    public interface IDciFilenameGenerator
    {
        void LogUniqueDciFilename(List<ServerNameAppIdDto> args);
        string GenerateUniqueDciFilename(string serverName, string appId);        
    }
}

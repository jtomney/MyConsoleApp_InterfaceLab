using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.UniqueFilenameClass
{
    public class DciFilenameGenerator : IDciFilenameGenerator
    {
        private readonly ILogger _logger;
        public DciFilenameGenerator (ILogger logger)
        {
            _logger = logger;            
        }
        public void LogUniqueDciFilename(List<ServerNameAppIdDto> args)
        {
            foreach (var arg in args)
            {
                string uniqueFilename = GenerateUniqueDciFilename(arg.Servername, arg.AppId);
                _logger.LogMsg(uniqueFilename);
            }
        }
        public string GenerateUniqueDciFilename(string serverName, string appId)
        {
            DateTime timestamp = DateTime.Now;
            string timestampStr = timestamp.ToString("yyyyMMddHHmmssffff");

            return serverName + appId + timestampStr;
        }
    }
}

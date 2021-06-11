using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.UniqueFilenameClass
{
    public class UniqueFilename : IUniqueFilename
    {
        private readonly ILogger _logger;
        public UniqueFilename (ILogger logger)
        {
            _logger = logger;            
        }
        public void LogUniqueFilename(List<ArgumentsDto> args)
        {
            foreach (var arg in args)
            {
                string uniqueFilename = GenerateUniqueFilename(arg.Servername, arg.AppId);
                _logger.LogMsg(uniqueFilename);
            }
        }
        public string GenerateUniqueFilename(string serverName, string appId)
        {
            DateTime timestamp = DateTime.Now;
            string timestampStr = timestamp.ToString("yyyyMMddHHmmssffff");

            return serverName + appId + timestampStr;
        }
    }
}

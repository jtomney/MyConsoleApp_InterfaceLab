using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.UniqueFilenameClass
{
    public class CommandLineArgsParser : ICommandLineArgsParser
    {
        public List<ServerNameAppIdDto> ParseCmdLineArgsToSrvNmAppIdDTOs(string[] args)
        {
            var result = new List<ServerNameAppIdDto>();

            foreach(string arg in args)
            {
                string[] serverAndAppId = arg.Split(','); 
                result.Add(new ServerNameAppIdDto()
                {
                    Servername = serverAndAppId[0].Trim(),
                    AppId = serverAndAppId[1].Trim()
                });
            }

            return result;
        }
    }
}

using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp.UniqueFilenameClass
{
    public class Arguments : IArguments
    {
        public List<ArgumentsDto> ParseArguments(string[] args)
        {
            var argumentsList = new List<ArgumentsDto>();

            foreach(string arg in args)
            {
                string[] serverAndAppId = arg.Split(',').Select(argValue => argValue.Trim()).ToArray();
                argumentsList.Add(new ArgumentsDto()
                {
                    Servername = serverAndAppId[0],
                    AppId = serverAndAppId[1]
                });
            }

            return argumentsList;
        }
    }
}

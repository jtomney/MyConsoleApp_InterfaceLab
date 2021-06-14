using MyConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleAppUnitTests.Fake
{
    class FakeLogger : ILogger
    {
        List<string> _msgs = new List<string>();

        public void LogMsg(string msg)
        {
            _msgs.Add(msg);
        }
    }
}

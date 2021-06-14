using System;
using System.Collections.Generic;
using System.Text;
using MyConsoleApp.Interfaces;

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

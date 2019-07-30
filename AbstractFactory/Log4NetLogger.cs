using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Http
{
    class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Http
{
    static class HttpTester
    {
        internal static void Test()
        {
            // auth -> logger -> comp

            var compressor = new Compressor(null);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);

            var server = new WebServer(authenticator);
            
            server.Handle(new HttpRequest("admin", "1234"));

            server.Handle(new HttpRequest("admin", "12345"));
        }
    }
}

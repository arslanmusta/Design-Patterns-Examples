using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Http
{
    class HttpRequest
    {
        public string UserName { get; }

        public string Password { get; }

        public HttpRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        
    }
}

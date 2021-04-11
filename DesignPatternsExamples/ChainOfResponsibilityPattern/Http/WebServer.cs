using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Http
{
    class WebServer
    {
        private readonly Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}

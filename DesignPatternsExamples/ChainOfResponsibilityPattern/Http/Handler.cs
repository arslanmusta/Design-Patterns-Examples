using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Http
{
    abstract class Handler
    {
        private Handler _next;

        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
            {
                return;
            }

            _next?.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}

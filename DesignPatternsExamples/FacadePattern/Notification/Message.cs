using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Notification
{
    class Message
    {
        private readonly string _message;

        public Message(string message)
        {
            _message = message;
        }
    }
}

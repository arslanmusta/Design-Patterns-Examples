﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Notification
{
    class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appID", "Key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}

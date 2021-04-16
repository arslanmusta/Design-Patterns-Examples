using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Notification
{
    static class NotificationTester
    {
        internal static void Test()
        {
            var service = new NotificationService();
            service.Send("Hello World", "target");
        }
    }
}

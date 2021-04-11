using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.UserInterface
{
    static class UserInterfaceTester
    {
        internal static void Test()
        {
            var dialog = new ArticlesDialogBox();
            dialog.Simulate();
        }
    }
}

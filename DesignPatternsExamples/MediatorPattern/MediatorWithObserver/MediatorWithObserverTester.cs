using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.MediatorWithObserver
{
    static class MediatorWithObserverTester
    {
        internal static void Test()
        {
            var dialog = new ArticlesDialogBox();
            dialog.Simulate();
        }
    }
}

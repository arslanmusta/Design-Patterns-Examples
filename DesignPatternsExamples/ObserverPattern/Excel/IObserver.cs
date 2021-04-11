using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Excel
{
    interface IObserver
    {
        // Push Style
        //void Update(int value);
        
        // Pull Style
        void Update();
    }
}

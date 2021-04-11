using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Excel
{
    class DataSource : Subject
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                // Push style
                //NotifyObserver(_value);

                // Pull Style
                NotifyObserver();
            }
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Excel
{
    class Chart : IObserver
    {
        // Pull Style
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        // Push Style
        //public void Update(int value)
        //{
        //    Console.WriteLine($"Chart got updated. {value}");
        //}

        // Pull Style
        public void Update()
        {
            Console.WriteLine($"Chart got updated. {_dataSource.Value}");
        }
    }
}

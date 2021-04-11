using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Excel
{
    class SpreadSheet : IObserver
    {
        // Pull style
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        // Pull style
        //public void Update(int value)
        //{
        //    Console.WriteLine($"SpreadSheet got notified. {value}");
        //}

        // Push Style
        public void Update()
        {
            Console.WriteLine($"SpreadSheet got notified. {_dataSource.Value}");
        }
    }
}

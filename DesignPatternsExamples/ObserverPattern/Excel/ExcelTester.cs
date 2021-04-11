using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Excel
{
    static class ExcelTester
    {
        internal static void Test()
        {
            var dataSource = new DataSource();

            // Push Style
            //var sheet1 = new SpreadSheet();
            //var sheet2 = new SpreadSheet();
            //var chart = new Chart();

            // Pull style
            var sheet1 = new SpreadSheet(dataSource);
            var sheet2 = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheet1);
            dataSource.AddObserver(sheet2);
            dataSource.AddObserver(chart);

            dataSource.Value = 1;

        }
    }
}

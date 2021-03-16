using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Audit
{
    public static class AuditTester
    {
        public static void Test()
        {
            var task = new TransferMoneyTask();
            task.Execute();

            var task2 = new GenerateReportTask();
            task2.Execute();
        }
    }
}

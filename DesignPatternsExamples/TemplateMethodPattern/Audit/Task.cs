using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Audit
{
    public abstract class Task
    {
        private readonly AuditTrail _auditTrail;

        protected Task()
        {
            _auditTrail = new AuditTrail();
        }
        
        protected Task(AuditTrail auditTrail)
        {
            _auditTrail = auditTrail;
        }

        public void Execute()
        {
            _auditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}

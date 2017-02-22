using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POPEntities
{

    public class POP_HANDLING_APPLY_CONTAINER
    {

        public virtual string APPLY_NO { get; set; }

        public virtual string MASTER_APPLY_NO { get; set; }

        public virtual string VISA_NO { get; set; }

        public virtual string PORT { get; set; }

        public virtual string APPLY_BY { get; set; }

        public virtual string APPLY_ORG { get; set; }

        public virtual DateTime APPLY_DT { get; set; }

        public virtual string CANCEL_BY { get; set; }

        public virtual DateTime? CANCEL_DT { get; set; }

        public virtual string CANCEL_REASON { get; set; }

        public virtual string AUDIT_BY { get; set; }

        public virtual DateTime? AUDIT_DT { get; set; }

        public virtual string AUDIT_STATUS { get; set; }

        public virtual string LAST_MODIFY_ID { get; set; }

        public virtual DateTime LAST_MODIFY_DT { get; set; }
    }

}


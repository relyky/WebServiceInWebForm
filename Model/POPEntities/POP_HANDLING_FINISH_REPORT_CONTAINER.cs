using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POPEntities
{
    public class POP_HANDLING_FINISH_REPORT_CONTAINER
    {
        public virtual string APPLY_NO { get; set; }
        public virtual string MASTER_APPLY_NO { get; set; }
        public virtual string VISA_NO { get; set; }
        public virtual string PORT { get; set; }
        public virtual DateTime? REPORT_DT { get; set; }
        public virtual string APPLY_USER_ID { get; set; }
        public virtual decimal UP_WORK_TIME { get; set; }
        public virtual decimal DW_WORK_TIME { get; set; }
        public virtual decimal UP_DELAY_TIME { get; set; }
        public virtual decimal DW_DELAY_TIME { get; set; }
        public virtual decimal HOUR_QTY { get; set; }
        public virtual string OUA { get; set; }
        public virtual int OP_NUM { get; set; }
        public virtual string KEYIN_ID { get; set; }
        public virtual string STEVEDORING_ADMIN { get; set; }
        public virtual string WAREHOUSE_HEAD { get; set; }
        public virtual int NUM_BOOM { get; set; }
        public virtual string WHARF { get; set; }
        public virtual DateTime? START_DT { get; set; }
        public virtual DateTime? END_DT { get; set; }
        public virtual decimal BOAT_TIME { get; set; }
        public virtual DateTime? BERTHING_DT { get; set; }
        public virtual DateTime? OFFSHORE_DT { get; set; }
        public virtual decimal PARK_TIME { get; set; }
        public virtual string APPLY_BY { get; set; }
        public virtual DateTime? APPLY_DT { get; set; }
        public virtual string CANCEL_BY { get; set; }
        public virtual DateTime? CANCEL_DT { get; set; }
        public virtual string CANCEL_REASON { get; set; }
        public virtual string AUDIT_BY { get; set; }
        public virtual DateTime? AUDIT_DT { get; set; }
        public virtual string AUDIT_STATUS { get; set; }
        public virtual string LAST_MODIFY_ID { get; set; }
        public virtual DateTime? LAST_MODIFY_DT { get; set; }
        public virtual string TYPE { get; set; }
        public virtual string MAIN_MASTER_APPLY_NO { get; set; }
        public virtual string STEVEDORE_C { get; set; }
        public virtual string ORIGIN_APPLY_NO { get; set; }
        public virtual bool IS_MATCH_PROCESS { get; set; }
        public virtual string APPLY_ORG { get; set; }
        public virtual bool MATCH_FLAG1 { get; set; }
        public virtual bool MATCH_FLAG2 { get; set; }
        public virtual bool IS_AGENT { get; set; }
        public virtual string MGT_CENTER { get; set; }
        public virtual string HISTORY_ID { get; set; }


    }
}

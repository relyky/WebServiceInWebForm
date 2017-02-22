using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POPEntities
{

    public class POP_HANDLING_EFFICIENCY_CONTAINER_ITEM
    {

        public virtual Int32 DETAIL_NO { get; set; }

        public virtual String VISA_NO { get; set; }

        public virtual String WHARF { get; set; }

        public virtual String STEVEDORE_C { get; set; }

        public virtual String MACHINES_CODE { get; set; }

        public virtual DateTime START_DT { get; set; }

        public virtual DateTime END_DT { get; set; }

        public virtual Decimal WORK_TIME { get; set; }

        public virtual Decimal TOTAL_DELAY_TIME { get; set; }

        public virtual Decimal TOTAL_WORK_TIME { get; set; }

        public virtual Decimal LOAD_DT { get; set; }

        public virtual Decimal UNLOAD_DT { get; set; }

        public virtual Decimal OP_NUM { get; set; }

        public virtual Decimal WAIT_BERTHING { get; set; }

        public virtual Decimal WAIT_MACHINES { get; set; }

        public virtual Decimal WAIT_LIFING_COVER { get; set; }

        public virtual Decimal WAIT_EQPT_ERR { get; set; }

        public virtual Decimal WAIT_MACH_ERR { get; set; }

        public virtual Decimal WAIT_CRANE { get; set; }

        public virtual Decimal WAIT_OTHER { get; set; }

        public virtual Int32 LOAD_CONTAINER_20 { get; set; }

        public virtual Int32 LOAD_CONTAINER_40 { get; set; }

        public virtual Int32 LOAD_CONTAINER_45 { get; set; }

        public virtual Int32 UNLOAD_CONTAINER_20 { get; set; }

        public virtual Int32 UNLOAD_CONTAINER_40 { get; set; }

        public virtual Int32 UNLOAD_CONTAINER_45 { get; set; }

        public virtual Int32 RESTOWAGE_F_20 { get; set; }

        public virtual Int32 RESTOWAGE_F_40 { get; set; }

        public virtual Int32 RESTOWAGE_F_45 { get; set; }

        public virtual Int32 RESTOWAGE_S_20 { get; set; }

        public virtual Int32 RESTOWAGE_S_40 { get; set; }

        public virtual Int32 RESTOWAGE_S_45 { get; set; }

        public virtual String LAST_UPD_USER { get; set; }

        public virtual DateTime LAST_MODIFY_DT { get; set; }

        public virtual bool ENABLE { get; set; }
    }

}

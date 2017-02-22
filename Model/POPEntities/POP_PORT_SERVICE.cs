using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POPEntities
{

    public class POP_PORT_SERVICE
    {

        public virtual String MASTER_APPLY_NO { get; set; }

        public virtual String VISA_NO { get; set; }

        public virtual String TEMP_VISA_NO { get; set; }

        public virtual String APPLICANT { get; set; }

        public virtual String SHIPPING_CARRIERS { get; set; }

        public virtual String ID_CARD_NUM { get; set; }

        public virtual String VAT { get; set; }

        public virtual DateTime? APPLY_DT { get; set; }

        public virtual DateTime? LAST_MODIFY_DT { get; set; }

        public virtual Int32 MANIFEST_ID { get; set; }

        public virtual DateTime? START_DT { get; set; }

        public virtual Int32 STATUS { get; set; }

        public virtual Boolean WAREHOUSE_OUT_EXPORT { get; set; }

        public virtual Boolean WAREHOUSE_OUT_IMPORT { get; set; }

        public virtual Boolean WAREHOUSE_IN_EXPORT { get; set; }

        public virtual Boolean WAREHOUSE_IN_IMPORT { get; set; }

        public virtual Boolean CY_APPLY { get; set; }

        public virtual Boolean MY_IN_APPLY { get; set; }

        public virtual Boolean MY_OUT_APPLY { get; set; }

        public virtual Boolean CONTAINER_TYPE_OTHER { get; set; }

        public virtual Boolean PT_EQUIPMENT_APPLY { get; set; }

        public virtual Boolean PT_LOCATION_APPLY { get; set; }

        public virtual Boolean MCH_APPLY { get; set; }

        public virtual Boolean CONTAINER_SECURITY_APPLY { get; set; }

        public virtual Boolean SINGLE_LOADING_APPLY { get; set; }

        public virtual Boolean DEVANNING_APPLY { get; set; }

        public virtual Boolean NIGHT_EQUIPMENT_CHARGE { get; set; }

        public virtual Boolean DETENTION_CHARGE { get; set; }

        public virtual Boolean WEIGHHOUSE_CHARGE { get; set; }

        public virtual Boolean OTHER_CHARGE { get; set; }

        public virtual String IS_CHECKOUT { get; set; }

        public virtual String STEVEDORE_C { get; set; }

        public virtual String APPLY_ORG_CODE { get; set; }

        public virtual String PORT { get; set; }

        public virtual Boolean INTERNAL_INWAREHOUSE { get; set; }

        public virtual Boolean INTERNAL_OUTWAREHOUSE { get; set; }

        public virtual String DEPUTY_BY { get; set; }

        public virtual Boolean IS_FREE_PORT { get; set; }

        public virtual Boolean IS_HANDLING_LOCK { get; set; }

        public virtual String HANDLING_TYPE { get; set; }

        public virtual String DEPUTY_NAME { get; set; }

        public virtual String APPLY_ORG_NAME { get; set; }

        public virtual String BAN_NO { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model.POPEntities
{

    public class POP_HANDLING_EFFICIENCY_CONTAINER
    {

        public virtual String VISA_NO { get; set; }

        public virtual String HISTORY_ID { get; set; }

        public virtual String WHARF { get; set; }

        public virtual String MGT_CENTER { get; set; }

        public virtual DateTime ASSIGN_DT { get; set; }

        public virtual DateTime FINISH_DT { get; set; }

        public virtual Boolean IS_FINISH { get; set; }

        public virtual Decimal EXPECT_LOAD_TON { get; set; }

        public virtual Decimal EXPECT_UNLOAD_TON { get; set; }

        public virtual String LAST_UPD_USER { get; set; }

        public virtual DateTime LAST_MODIFY_DT { get; set; }

        public virtual Decimal TOTAL_DELAY_TIME { get; set; }

        public virtual Decimal TOTAL_WORK_TIME { get; set; }

        public virtual Decimal DELAY_UNLOAD_MACH_TIME { get; set; }

        public virtual Decimal DELAY_LOAD_MACH_TIME { get; set; }

        public virtual Decimal DELAY_UNLOAD_OP_TIME { get; set; }

        public virtual Decimal DELAY_LOAD_OP_TIME { get; set; }

        public virtual String APPLY_BY { get; set; }

        public virtual String APPLY_ORG { get; set; }

        public virtual Boolean ENABLE { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as POP_HANDLING_EFFICIENCY_CONTAINER;
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            // To compare PK fields.
            return this.VISA_NO.Equals(other.VISA_NO) &&
                    this.WHARF.Equals(other.WHARF);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                hash = (hash * 31) ^ this.VISA_NO.GetHashCode();
                hash = (hash * 31) ^ this.WHARF.GetHashCode();
                return hash;
            }
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.POPEntities
{
    public class POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER_SPECIAL
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public virtual int SEQ { get; set; }

        /// <summary>
        /// 完工報告表單號
        /// </summary>
        public virtual string APPLY_NO { get; set; }

        /// <summary>
        /// 櫃別   例：10 呎櫃為A  冷凍櫃為B
        /// </summary>
        public virtual string KIND { get; set; }

        /// <summary>
        ///  類別    C：實櫃   E：空櫃
        /// </summary>
        public virtual string TYPE { get; set; }

        /// <summary>
        /// 櫃尺
        /// </summary>
        public virtual int SIZE { get; set; }

        /// <summary>
        /// 進口卸櫃
        /// </summary>
        public virtual int DW { get; set; }

        /// <summary>
        /// 出口裝櫃
        /// </summary>
        public virtual int UP { get; set; }

        /// <summary>
        /// 轉口卸櫃
        /// </summary>
        public virtual int RE_DW { get; set; }

        /// <summary>
        ///  轉口裝櫃
        /// </summary>
        public virtual int RE_UP { get; set; }

        /// <summary>
        /// 轉運卸櫃
        /// </summary>
        public virtual int RL_DW { get; set; }

        /// <summary>
        /// 轉運裝櫃
        /// </summary>
        public virtual int RL_UP { get; set; }

        /// <summary>
        /// 一次翻艙（同船翻艙）
        /// </summary>
        public virtual int RW1 { get; set; }

        /// <summary>
        ///  二次翻艙（碼頭翻艙）
        /// </summary>
        public virtual int RW2 { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public virtual string REMARK { get; set; }

        /// <summary>
        /// 最後更新使用者
        /// </summary>
        public virtual string LAST_MODIFY_ID { get; set; }

        /// <summary>
        /// 最後更新時間
        /// </summary>
        public virtual DateTime? LAST_MODIFY_DT { get; set; }
    }
}


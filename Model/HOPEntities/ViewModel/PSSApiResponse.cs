using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model.HOPEntities.ViewModel
{
    /// <summary>
    /// API回應用訊息
    /// </summary>
    [Serializable]
    [DataContract]
    public class PSSApiResponse
    {
        /// <summary>
        /// 處理狀況
        /// </summary>
        [DataMember]
        public bool processStatus { get; set; }

        /// <summary>
        /// 是否發生錯誤
        /// </summary>
        [DataMember]
        public bool errorHappend { get; set; }

        /// <summary>
        /// 回傳訊息
        /// </summary>
        [DataMember]
        public string msg { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        [DataMember]
        public string errorMsg { get; set; }

        public PSSApiResponse() { }
        public PSSApiResponse(bool processStatus, bool errorHappend,
            string msg, string errorMsg)
        {
            this.processStatus = processStatus;
            this.errorHappend = errorHappend;
            this.msg = msg;
            this.errorMsg = errorMsg;
        }
    }

}

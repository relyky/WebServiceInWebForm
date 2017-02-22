using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceInWebForm.DataConstract
{
    /// <summary>
    /// 全名為Response Message回傳訊息格式。
    /// </summary>
    /// <remarks>
    /// RespMsg := { 
    ///  result := “SUCCESS”/“FAIL”, 
    ///  message := APPLY_NO/message, 
    ///  tag := …
    /// }
    /// </remarks>
    public class RespMsg
    {
        public String Result;
        public String Message;
        public String Tag;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceInWebForm.DataConstract
{
    /// <summary>
    /// 指定上傳執行動作，有新增create、修改modify等
    /// </summary>
    /// <remarks>Act := {
    ///act := “CREATE”/“MODIFY”, 
    ///tag := …
    ///</remarks>
    public class PSSApiAct
    {
        public String Action;
        public String Tag;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebServiceInWebForm.DataConstract;
using Model.POPEntities;
using Model.HOPEntities.ViewModel;

namespace WebServiceInWebForm.WS
{
    /// <summary>
    ///MyWebService1 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]  // POP Handling Data Uploading
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Echo(String arg)
        {
            return arg;
        }

        /// <summary>
        /// 3.5	GetStatusOf_貨櫃－裝缷完工報告表
        /// </summary>
        [WebMethod]
        public PSSApiResponse GetStatusOfContainerHandlingFinishReport(String apply_no)
        {
            // resource
            //PSSApiResponse respMsg = new PSSApiResponse(false, false, "ERROR", "預設失敗。");

            try
            {
                //message = [已提交(未碰檔)、已碰檔、碰檔失敗、已審核]。
                //已提交(未碰檔)：SUBMIT 
                //已碰檔：MATCH_SUCC 
                //碰檔失敗：MATCH_FAIL 
                //已審核：APPROVED

                // 自資料庫取得審單狀態
                string formStatus = "MATCH_FAIL"; // 碰檔失敗

                // 檢查 --- 假裝失敗！
                if (apply_no.StartsWith("x"))
                {
                    return new PSSApiResponse(false, true, "ERROR", "我是失敗訊息！");
                }

                // success
                // 若成功，需回傳審單狀態。
                return new PSSApiResponse(true, false, formStatus, null); // 
            }
            catch (Exception ex)
            {
                return new PSSApiResponse(false, true, "EXCEPTION", ex.Message);
            } 
            finally
            {
                // release resource
                // ...
            }
        }

        /// <summary>
        /// 3.1	Upload_棧埠服務申請介面
        /// </summary>
        [WebMethod]
        public PSSApiResponse UploadPOPPortServiceApply(PSSApiAct act, POP_PORT_SERVICE formData)
        {
            // resource
            // PSSApiResponse respMsg = new PSSApiResponse(false, false, "ERROR", "預設失敗。");

            // 前置檢查
            if(String.IsNullOrWhiteSpace(formData.VISA_NO))
            {
                return new PSSApiResponse(false, true, "ERROR", "VISA_NO不可空白！");
            }

            // GO
            try
            {
                switch(act.Action)
                {
                    case "CREATE":
                        //...
                        break;
                    case "MODIFY":
                        //...
                        break;
                    default:
                        // ERROR
                        return new PSSApiResponse(false, true, "ERROR", "觸發了預期之外的行為。");
                        //break;
                }

                // success
                return new PSSApiResponse(true, false, "I_am_APPLY_NO", null);
            }
            catch (Exception ex)
            {
                return new PSSApiResponse(false, true, "EXCEPTION", ex.Message);
            }
            finally
            {
                // release resource
                // ...
            }
        }
        
        /// <summary>
        /// 3.2	Upload_貨櫃裝卸明細申報
        /// </summary>
        [WebMethod]
        public PSSApiResponse UploadContainerHandlingApply(PSSApiAct act, POP_HANDLING_APPLY_CONTAINER formData, POP_HANDLING_APPLY_CONTAINER_ITEM formItem) 
        {
            return new PSSApiResponse(false, true, "NOT_IMPLEMENTED", "未實作。");
        }

        /// <summary>
        /// 3.3	Upload_貨櫃－裝卸動態及效率報表
        /// </summary>
        [WebMethod]
        public PSSApiResponse UploadContainerHandlingEfficiency(
            PSSApiAct act,
            POP_HANDLING_EFFICIENCY_CONTAINER formData,
            List<POP_HANDLING_EFFICIENCY_CONTAINER_ITEM> formItem)
        {
            return new PSSApiResponse(false, true, "NOT_IMPLEMENTED", "未實作。");
        }

        /// <summary>
        /// 3.4	Upload_貨櫃－裝缷完工報告表
        /// </summary>
        [WebMethod]
        public PSSApiResponse UploadContainerHandlingFinishReport(PSSApiAct act, 
            POP_HANDLING_FINISH_REPORT_CONTAINER formData,
            POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER formItem,
            List<POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER_SPECIAL> formItem2)
        {
            // resource
            // PSSApiResponse respMsg = new PSSApiResponse(false, false, "ERROR", "預設失敗。");

            // 前置檢查
            if (String.IsNullOrWhiteSpace(formData.VISA_NO))
            {
                return new PSSApiResponse(false, true, "ERROR", "VISA_NO不可空白！");
            }

            // GO
            try
            {
                switch (act.Action)
                {
                    case "CREATE":
                        //...
                        break;
                    case "MODIFY":
                        //...
                        break;
                    default:
                        // ERROR
                        return new PSSApiResponse(false, true, "ERROR", "觸發了預期之外的行為。");
                        //break;
                }

                // success
                return new PSSApiResponse(true, false, "I_am_APPLY_NO", null);
            }
            catch (Exception ex)
            {
                return new PSSApiResponse(false, true, "EXCEPTION", ex.Message);
            }
            finally
            {
                // release resource
                // ...
            }
        }
    }
}
    
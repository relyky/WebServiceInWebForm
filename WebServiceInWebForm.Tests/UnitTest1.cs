using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebServiceInWebForm.Tests.MyWebService1;
using System.Collections.Generic;

namespace WebServiceInWebForm.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MyWebService1SoapClient ws = new MyWebService1SoapClient();
            String hello = ws.HelloWorld();
            Assert.AreEqual("Hello World", hello);
        }

        [TestMethod]
        public void TestEcho()
        {
            MyWebService1SoapClient ws = new MyWebService1SoapClient();
            String kokoko = "ABCD1234我是中文字";
            String echo = ws.Echo(kokoko);
            Assert.AreEqual(kokoko, echo);
        }

        [TestMethod]
        public void Test_GetStatus()
        {
            // prepare
            MyWebService1SoapClient ws = new MyWebService1SoapClient();
            String apply_no = "ABCD5678XYZ987";

            // GO
            PSSApiResponse returnMsg = ws.GetStatusOfContainerHandlingFinishReport(apply_no);

            // expect value
            PSSApiResponse expectMsg = new PSSApiResponse()
            {
                processStatus = true,
                errorHappend = false,
                msg = "MATCH_FAIL",
                errorMsg = null
            };

            // compare
            Assert.AreEqual(expectMsg.processStatus, returnMsg.processStatus);
            Assert.AreEqual(expectMsg.errorHappend, returnMsg.errorHappend);
            Assert.AreEqual(expectMsg.msg, returnMsg.msg);
            Assert.AreEqual(expectMsg.errorMsg, returnMsg.errorMsg);
        }

        [TestMethod]
        public void Test_GetStatus_2()
        {
            // prepare
            MyWebService1SoapClient ws = new MyWebService1SoapClient();
            String apply_no = "xABCD5678XYZ987"; // 送出會使得失敗的參數

            // GO
            PSSApiResponse returnMsg = ws.GetStatusOfContainerHandlingFinishReport(apply_no);

            // expect value
            PSSApiResponse expectMsg = new PSSApiResponse()
            {
                processStatus = false,
                errorHappend = true,
                msg = "ERROR",
                errorMsg = "我是失敗訊息！"
            };

            // compare
            Assert.AreEqual(expectMsg.processStatus, returnMsg.processStatus);
            Assert.AreEqual(expectMsg.errorHappend, returnMsg.errorHappend);
            Assert.AreEqual(expectMsg.msg, returnMsg.msg);
            Assert.AreEqual(expectMsg.errorMsg, returnMsg.errorMsg);
        }

        [TestMethod]
        public void Test_UploadPOPPortServiceApply_CREATE()
        {
            // prepare
            MyWebService1SoapClient ws = new MyWebService1SoapClient();

            PSSApiAct act = new PSSApiAct()
            {
                Action = "CREATE",
                Tag = ""
            };

            POP_PORT_SERVICE formData = new POP_PORT_SERVICE();
            formData.VISA_NO = "VISA1234567890";

            // GO
            PSSApiResponse returnMsg = ws.UploadPOPPortServiceApply(act, formData);

            // expect result
            PSSApiResponse expectMsg = new PSSApiResponse()
            {
                processStatus = true,
                errorHappend = false,
                msg = "I_am_APPLY_NO",
                errorMsg = null
            };

            // compare
            Assert.AreEqual(expectMsg.processStatus, returnMsg.processStatus);
            Assert.AreEqual(expectMsg.errorHappend, returnMsg.errorHappend);
            Assert.AreEqual(expectMsg.msg, returnMsg.msg);
            Assert.AreEqual(expectMsg.errorMsg, returnMsg.errorMsg);

            // 連資料庫驗證 IF EXISTS (SELECT * FROM POP_PORT_SERVICE WHERE APPLY_NO = apply_no )
            //...
        }

        [TestMethod]
        public void Test_UploadPOPPortServiceApply_MODIFY()
        {
            // prepare
            MyWebService1SoapClient ws = new MyWebService1SoapClient();

            PSSApiAct act = new PSSApiAct()
            {
                Action = "MODIFY",
                Tag = ""
            };

            POP_PORT_SERVICE formData = new POP_PORT_SERVICE();
            formData.VISA_NO = "VISA1234567890";
            formData.DEPUTY_NAME = "new deputy name";

            // GO
            PSSApiResponse returnMsg = ws.UploadPOPPortServiceApply(act, formData);

            // expect result
            PSSApiResponse expectMsg = new PSSApiResponse()
            {
                processStatus = true,
                errorHappend = false,
                msg = "I_am_APPLY_NO",
                errorMsg = null
            };

            // compare
            Assert.AreEqual(expectMsg.processStatus, returnMsg.processStatus);
            Assert.AreEqual(expectMsg.errorHappend, returnMsg.errorHappend);
            Assert.AreEqual(expectMsg.msg, returnMsg.msg);
            Assert.AreEqual(expectMsg.errorMsg, returnMsg.errorMsg);

            // 連資料庫驗證 IF EXISTS ( SELECT * FROM POP_PORT_SERVICE WHERE APPLY_NO = apply_no AND DEPUTY_NAME = "new deputy name" )
            //...
        }

        [TestMethod]
        public void Test_UploadContainerHandlingFinishReport_CREATE()
        {
            // prepare
            MyWebService1SoapClient ws = new MyWebService1SoapClient();

            PSSApiAct act = new PSSApiAct()
            {
                Action = "CREATE",
                Tag = ""
            };

            POP_HANDLING_FINISH_REPORT_CONTAINER formData = new POP_HANDLING_FINISH_REPORT_CONTAINER();
            formData.VISA_NO = "VISA1234567890";
            formData.APPLY_NO = "APPLY12345678";

            POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER formItem = new POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER();
            formItem.APPLY_NO = formData.APPLY_NO;

            List<POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER_SPECIAL> formItem2 = new List<POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER_SPECIAL>();
            formItem2.Add(new POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER_SPECIAL()
            {
                APPLY_NO = formData.APPLY_NO,
                DW = 901,
            });
            formItem2.Add(new POP_HANDLING_FINISH_REPORT_ITEMS_CONTAINER_SPECIAL()
            {
                APPLY_NO = formData.APPLY_NO,
                DW = 902,
            });

            // GO
            PSSApiResponse returnMsg = ws.UploadContainerHandlingFinishReport(
                                    act,
                                    formData,
                                    formItem,
                                    formItem2.ToArray());

            // expect result
            PSSApiResponse expectMsg = new PSSApiResponse()
            {
                processStatus = true,
                errorHappend = false,
                msg = "I_am_APPLY_NO",
                errorMsg = null
            };

            // compare
            Assert.AreEqual(expectMsg.processStatus, returnMsg.processStatus);
            Assert.AreEqual(expectMsg.errorHappend, returnMsg.errorHappend);
            Assert.AreEqual(expectMsg.msg, returnMsg.msg);
            Assert.AreEqual(expectMsg.errorMsg, returnMsg.errorMsg);

            // 連資料庫驗證 IF EXISTS (SELECT * FROM POP_PORT_SERVICE WHERE APPLY_NO = apply_no )
            //...
        }

    }
}

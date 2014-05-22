using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.SendAlertWebService;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsImpl
    {
        [TestMethod]
        public void TestConnect()
        {
            string response = _sendAlertAsync(new Alert(){ AlertMessage="TEST" }).Result;
            Assert.AreEqual("OK", response);
        }

        [TestMethod]
        public void TestSendEmailAlert()
        {
            string response = _sendAlertAsync(new Alert(){ AlertMessage="Email", Receivers = new int[]{ 1 }}).Result;
            Assert.IsTrue(response.StartsWith("Alert"));
        }

        [TestMethod]
        public void TestSendRESTAlert()
        {
            string response = _sendAlertAsync(new Alert(){ AlertMessage="REST", Receivers = new int[]{ 2 }}).Result;
            Assert.IsTrue(response.StartsWith("Alert"));
        }

        [TestMethod]
        public void TestSendAllAlert()
        {
            string response = _sendAlertAsync(new Alert(){ AlertMessage="All", Receivers = new int[]{ 1,2,3 }}).Result;
            Assert.IsTrue(response.StartsWith("Alert"));
        }

        private async Task<string> _sendAlertAsync(Alert alert)
        {
            var client = new SendAlertClient();
            return await client.SendAlertAsync(alert);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailSender;
using MandrillMailSender;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsMandrill
    {
        static Mail mail;
        static MandrillSender sender;

        [ClassInitialize]
        static public void initializeClass(TestContext context)
        {
            mail = new Mail("Test content", "test subject", false);
            sender = new MandrillSender("api-key","from mail");
        }
        [TestMethod]
        public void SendMailTestResponseSent()
        {
            Response response = sender.SendMail(mail);
            Assert.AreEqual("", response.Message);
        }
        [TestMethod]
        public void SendMailTestResponseWrongMail()
        {

        }
        [TestMethod]
        public void SendMailTestResonse()
        {
        }
        [TestMethod]
        public void SendMailTest()
        {
        }
    }
}

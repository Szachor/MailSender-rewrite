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
        static Receiver goodRecipient;
        static Receiver wrongRecipient;


        [ClassInitialize]
        static public void initializeClass(TestContext context)
        {
            mail = new Mail("Test content", "test subject", false);
            sender = new MandrillSender("Yt2RkGJrlFG6LD3BanmsWw", "testmailsender4@gmail.com");
            goodRecipient = new Receiver("testmailsender4@gmail.com", "Good mail");
            wrongRecipient = new Receiver("testmailsender4", "Bad mail");
        }
        [TestMethod]
        public void SendMailTestResponseSent()
        {
            MandrillResponse response = sender.SendMail(mail, goodRecipient);
            Assert.AreEqual("sent", response.Message);
        }
        [TestMethod]
        public void SendMailTestResponseWrongMail()
        {
            MandrillResponse response = sender.SendMail(mail, goodRecipient);
            Assert.AreNotEqual("sent", response.Message);
        }
        [TestMethod]
        public void PingResponePong()
        {
            MandrillResponse response = sender.TestSender();
            Assert.AreNotEqual("Ping", response.Message);
        }
        [TestMethod]
        public void SendMailTest()
        {
        }
    }
}

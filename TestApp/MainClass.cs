// -----------------------------------------------------------------------
//  <copyright file="MainClass.cs" company="m (m.dobrzynski@outlook.com)">
//      Author: m (m.dobrzynski@outlook.com).
//  </copyright>
// -----------------------------------------------------------------------

namespace TestApp
{
    using System;
    using MailChimpMailSender;
    using MailSender;
    using MandrillMailSender;

    /// <summary>
    /// Klasa programu testującego działanie klas MandrillMailSender
    /// oraz MailChimpMailSender
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Metoda główna programu.
        /// </summary>
        /// <param name="args">Parametry przekazane do programu.</param>
        public static void Main(string[] args)
        {
            ISender mandrill = new MandrillSender("", "");
            ISender mailchimp = new MailChimpSender("", "");
            Mail m = new Mail("test", "test", false);
            Receiver r = new Receiver("", "");
            Response re = mandrill.TestSender();
            re = mandrill.SendMail(m, r);
            Console.WriteLine ();
            //mailchimp.TestSender();
        }
    }
}

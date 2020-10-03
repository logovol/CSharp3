using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace MailSender.lib
{
    public class MailSenderService
    {
        public string ServerAddress { get; set; }
        public int ServerPort { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool UseSSL { get; set; } 

        public void SendMessage(string SenderAddress, string RecipientAddress, string Subject, string Body)
        {
            var to = new MailAddress(SenderAddress);
            var from = new MailAddress(RecipientAddress);

            using (var message = new MailMessage(from, to))
            {
                message.Subject = Subject;
                message.Body = Body;

                var client = new SmtpClient(ServerAddress, ServerPort);
                client.EnableSsl = UseSSL;

                client.Credentials = new NetworkCredential()
                {
                    UserName = Login,
                    Password = Password
                };

                try
                {
                    client.Send(message);
                }
                catch (SmtpException e)
                {
                    Trace.TraceError(e.ToString());
                    throw;
                }                
            }
        }
    }
}

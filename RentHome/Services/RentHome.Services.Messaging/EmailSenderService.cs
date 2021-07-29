﻿namespace RentHome.Services.Messaging
{
    using MailKit.Net.Smtp;
    using MailKit.Security;
    using MimeKit;
    using MimeKit.Text;

    public class EmailSenderService : IEmailSenderService
    {
        public void SendMail(string from, string to, string subject, string html)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            var emailProject = "renthome997@gmail.com";
            var password = "vydccjvovokeeoro";

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate(emailProject, password);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}

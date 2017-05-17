// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// //  <summary>
//   Program.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Bridge
{
    using System;

    /// <summary>
    /// The message.
    /// </summary>
    public abstract class Message
    {
        /// <summary>
        /// Gets or sets the message sender.
        /// </summary>
        public IMessageSender MessageSender { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The send.
        /// </summary>
        public abstract void Send();
    }

    /// <summary>
    /// The system message.
    /// </summary>
    public class SystemMessage : Message
    {
        /// <summary>
        /// The send.
        /// </summary>
        public override void Send()
        {
            this.MessageSender.SendMessage(this.Subject, this.Body);
        }
    }

    /// <summary>
    /// The user message.
    /// </summary>
    public class UserMessage : Message
    {
        /// <summary>
        /// Gets or sets the user comments.
        /// </summary>
        public string UserComments { get; set; }

        /// <summary>
        /// The send.
        /// </summary>
        public override void Send()
        {
            var fullBody = string.Format("{0}\nUser Comments: {1}", this.Body, this.UserComments);
            this.MessageSender.SendMessage(this.Subject, fullBody);
        }
    }

    /// <summary>
    /// The email sender.
    /// </summary>
    public class EmailSender : IMessageSender
    {
        /// <summary>
        /// The send message.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="body">
        /// The body.
        /// </param>
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
        }
    }

    /// <summary>
    /// The msmq sender.
    /// </summary>
    public class MSMQSender : IMessageSender
    {
        /// <summary>
        /// The send message.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="body">
        /// The body.
        /// </param>
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
        }
    }

    /// <summary>
    /// The web service sender.
    /// </summary>
    public class WebServiceSender : IMessageSender
    {
        /// <summary>
        /// The send message.
        /// </summary>
        /// <param name="subject">
        /// The subject.
        /// </param>
        /// <param name="body">
        /// The body.
        /// </param>
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Service\n{0}\n{1}\n", subject, body);
        }
    }

    /// <summary>
    /// The program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            var usermsg = new UserMessage();
            usermsg.Subject = "Test Message";
            usermsg.Body = "Hi, This is a Test Message";
            usermsg.UserComments = "I hope you are well";

            usermsg.MessageSender = email;
            usermsg.Send();

            Console.ReadKey();
        }
    }
}
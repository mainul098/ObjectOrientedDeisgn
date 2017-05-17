// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMessageSender.cs" company="">
//   
// </copyright>
// //  <summary>
//   IMessageSender.cs
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Bridge
{
    /// <summary>
    /// The MessageSender interface.
    /// </summary>
    public interface IMessageSender
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
        void SendMessage(string subject, string body);
    }
}
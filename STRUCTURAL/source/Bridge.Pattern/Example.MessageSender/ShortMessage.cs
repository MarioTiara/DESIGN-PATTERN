using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.MessageSender
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void SendMessage(string Message)
        {
            if (Message.Length<=10) this._messageSender.sendMessage(Message);
            else Console.WriteLine("Unable t send the message as lenght >10 chars");
        }
    }
}
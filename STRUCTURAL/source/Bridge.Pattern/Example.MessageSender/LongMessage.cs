using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.MessageSender
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(IMessageSender messageSender) : base(messageSender)
        {
        }
        public override void SendMessage(string Message)=>this._messageSender.sendMessage(Message);
    }
}
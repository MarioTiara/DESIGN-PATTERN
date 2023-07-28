using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.MessageSender
{
    public abstract class AbstractMessage
    {
        protected IMessageSender _messageSender;
        public AbstractMessage (IMessageSender messageSender)=>this._messageSender=messageSender;

        public abstract void SendMessage(string Message);
    }
}
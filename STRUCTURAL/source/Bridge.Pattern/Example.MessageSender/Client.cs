using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.MessageSender
{
    public class Client
    {
        public static void Sent(AbstractMessage messager, string message)=>messager.SendMessage(message);
    }
}
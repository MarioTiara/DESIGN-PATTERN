using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.MessageSender
{
    public class SMSMessageSender : IMessageSender
    {
        public void sendMessage(string Message)
        {
            Console.WriteLine($"'{Message}' : This Message has been sent using SMS");
        }
    }
}
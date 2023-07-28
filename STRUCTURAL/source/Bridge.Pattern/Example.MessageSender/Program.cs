using Example.MessageSender;

var message="Hello world";



Console.WriteLine("==SMS===");
Client.Sent(new LongMessage(new SMSMessageSender()), message);
Console.WriteLine();
Client.Sent(new ShortMessage(new SMSMessageSender()), message);

Console.WriteLine("===EMAIL==");

Client.Sent(new LongMessage(new EmailMessageSender()), message);
Console.WriteLine();
Client.Sent(new ShortMessage(new EmailMessageSender()), message);
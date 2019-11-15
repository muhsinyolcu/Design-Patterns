using System;

namespace Bridge
{
    class EMailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine("{0} was sent via EMailSender", body.Title);
        }
    }
}

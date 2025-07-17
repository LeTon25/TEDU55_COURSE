using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    public class FacebookDecorator : Decorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        {
        }
        public override void SendMessage()
        {
            base.SendMessage();

            Console.WriteLine("Sending message from Facebook!");
        }
    }
}

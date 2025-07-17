using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample
{
    public class Notifier : INotifier
    {
        private string _message;

        public Notifier(string message)
        {
            _message = message;
        }

        public void SendMessage()
        {
            Console.WriteLine($"Sending email from notifier system with message : {_message}");
        }
    }
}

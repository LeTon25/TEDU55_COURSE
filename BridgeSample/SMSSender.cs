using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    public class SMSSender : ICommunication
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"SMS\n{subject}\n{body}\n");
        }
    }
}

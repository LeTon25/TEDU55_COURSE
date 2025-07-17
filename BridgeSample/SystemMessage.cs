using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    // You can extend the Abstraction without changing the Implementation
    // classes.
    public class SystemMessage : Message
    {
        public SystemMessage(ICommunication messageSender, string subject, string content) : base(messageSender, subject, content)
        {
        }

        public override void Send()
        {
            base._messageSender.SendMessage(Subject, Content);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample
{
    /// <sumary>
    /// The 'Bridge/Implementation" interface
    /// Implementation interface provides only primitive operations, while the Abstraction
    /// defines higher- level operations based on those primitives.
    /// </summary>
    public interface ICommunication
    {
        void SendMessage(string subject, string body);
    }
}

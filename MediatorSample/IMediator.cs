using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSample
{
    /// <summary>
    /// The Mediator interface, which defines a send message
    /// method which the concrete mediators must implement.
    /// </summary>
    public interface IMediator
    {
        public void SendMessage(string message, SnackBar snackBar);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoSample
{
    public interface IMemento
    {
        string GetName();
        int GetState();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeSample
{
    public interface IPrototype<T> where T : class
    {
        T Clone();
    }
}

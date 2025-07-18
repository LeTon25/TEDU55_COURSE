using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    // Iterator Interface
    // This is going to be an interface defining the operations for accessing and traversing elements in a sequence.
    public interface IAbstractIterator<T>
    {
        T First();
        T Next();
        bool IsCompleted { get; }
    }
}

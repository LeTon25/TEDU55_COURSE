using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorSample
{
    public interface IAbstractCollection<T>
    {
        // The following Method is going to Return an Iterator object.
        // Later, we will Implement the Iterator class
        IAbstractIterator<T> CreateIterator();
    }
}

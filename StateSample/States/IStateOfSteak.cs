using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSample.States
{
    public interface IStateOfSteak
    {
        void Cook(Steak steak);
    }
}

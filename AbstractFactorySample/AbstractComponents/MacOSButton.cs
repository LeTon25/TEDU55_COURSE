using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractComponents
{
    public class MacOSButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacOS Button");
        }
    }
}

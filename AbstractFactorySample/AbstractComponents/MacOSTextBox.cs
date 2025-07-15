using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractComponents
{
    public class MacOSTextBox : ITextBox
    {
        public void Input()
        {
            Console.WriteLine("MacOS TextBox");
        }
    }
}

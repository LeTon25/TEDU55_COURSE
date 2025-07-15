using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractComponents
{
    public class WindowsTextBox : ITextBox
    {
        public void Input()
        {
            Console.WriteLine("Windows TextBox");
        }
    }
}

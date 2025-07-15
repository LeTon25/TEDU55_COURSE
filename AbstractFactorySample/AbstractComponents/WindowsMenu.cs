using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractComponents
{
    public class WindowsMenu : IMenu
    {
        public void Select()
        {
            Console.WriteLine("Windows Menu");
        }
    }
}

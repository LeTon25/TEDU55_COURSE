using AbstractFactorySample.AbstractComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractFactories
{
    public class MacOSGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public IMenu CreateMenu()
        {
            return new MacOSMenu();
        }

        public ITextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }
}

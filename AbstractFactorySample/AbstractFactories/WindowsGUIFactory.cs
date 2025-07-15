using AbstractFactorySample.AbstractComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractFactories
{
    public class WindowsGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IMenu CreateMenu()
        {
            return new WindowsMenu();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}

using AbstractFactorySample.AbstractComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample.AbstractFactories
{
    public interface IGUIFactory
    {
        public IButton CreateButton();
        public IMenu CreateMenu();
        public ITextBox CreateTextBox();    
    }
}

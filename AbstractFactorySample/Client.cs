using AbstractFactorySample.AbstractFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    public class Client
    {
        public void Main()
        {
            // Generate Windows UI Controls
            GenerateUI(new WindowsGUIFactory());
            Console.WriteLine("===========================");
            // Generate MacOS UI Controls
            GenerateUI(new MacOSGUIFactory());
        }

        public void GenerateUI(IGUIFactory factory)
        {
            var textbox = factory.CreateTextBox();
            var button = factory.CreateButton();
            var menu = factory.CreateMenu();

            textbox.Input();
            button.Click();
            menu.Select();
        }
    }
}

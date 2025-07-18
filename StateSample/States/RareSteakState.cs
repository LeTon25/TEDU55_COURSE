using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSample.States
{
    public class RareSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            if (steak.GetTemperature() < 130)
            {
                Console.WriteLine("Cooking the steak rare.");
            }
            else
            {
                Console.WriteLine("Cooking the steak medium-rare.");
                steak.SetState(new MediumRareSteakState());
            }
        }
    }
}

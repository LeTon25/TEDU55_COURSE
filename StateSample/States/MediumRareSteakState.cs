using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSample.States
{
    public class MediumRareSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            if (steak.GetTemperature() <= 140)
            {
                Console.WriteLine("Cooking the steak medium-rare.");
            }
            else
            {
                Console.WriteLine("Cooking the steak medium.");
                steak.SetState(new MediumSteakState());
            }
        }
    }
}

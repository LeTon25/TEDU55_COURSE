﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSample.States
{
    public class MediumSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            if (steak.GetTemperature() < 165)
            {
                Console.WriteLine("Cooking the steak medium.");
            }
            else
            {
                Console.WriteLine("The steak is well done. Cooking is complete.");
                steak.SetState(new WellDoneSteakState());
            }
        }
    }
}

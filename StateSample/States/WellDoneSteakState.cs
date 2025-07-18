using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateSample.States
{
    public class WellDoneSteakState : IStateOfSteak
    {
        public void Cook(Steak steak)
        {
            Console.WriteLine("The steak is well done. Cooking is complete.");
        }
    }
}

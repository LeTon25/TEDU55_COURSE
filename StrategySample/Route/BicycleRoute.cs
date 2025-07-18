using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySample.Route
{
    // Concrete Strategy A
    // The following BicycleRoute Concrete Strategy implement the Strategy Interface and 
    // Implement the FindBestRoute Method. 
    public class BicycleRoute : IDirection
    {
        public void FindBestRoute()
        {
            Console.WriteLine("Returning best route for Bicycle");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public class CheapShipping : DeliveryMethod
    {
        public override IVehicle VehicleFactory()
        {
            return new Ship();
        }
    }
}

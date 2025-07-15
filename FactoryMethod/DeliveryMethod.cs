using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public abstract class DeliveryMethod
    {
        public abstract IVehicle VehicleFactory();

        public string Deliver()
        {
            var vehicle = VehicleFactory();

            var result = $"The item will be delivered by {vehicle.Operation()}";

            return result;
        }


    }
}

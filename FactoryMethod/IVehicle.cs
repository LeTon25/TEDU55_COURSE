using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public interface IVehicle
    {
        string Operation();
    }
    public class Ship : IVehicle
    {
        public string Operation()
        {
            return "Ship!";
        }
    }

    public class Car : IVehicle
    {
        public string Operation()
        {
            return "Car!";
        }
    }

    public class AirCraft : IVehicle
    {
        public string Operation()
        {
            return "Aircraft!";
        }
    }

    public class Train : IVehicle
    {
        public string Operation()
        {
            return "Train!";
        }
    }
}

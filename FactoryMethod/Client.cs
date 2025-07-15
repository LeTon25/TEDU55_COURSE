using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample
{
    public class Client
    {
        public void Deliver(DeliveryMethod deliveryMethod)
        {
            Console.WriteLine(deliveryMethod.Deliver());
        }
    }
}

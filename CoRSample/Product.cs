using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    public class Product
    {
        public string RequestType { get; set; }
        public double ProposedAmount { get; set; }

        public Product(string requestType, double proposedAmount)
        {
            RequestType = requestType;
            ProposedAmount = proposedAmount;

            Console.WriteLine($"Purchase request for {RequestType} for ${ProposedAmount} has been submitted");
        }
    }
}

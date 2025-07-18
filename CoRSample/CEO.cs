﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    public class CEO : BaseApprover
    {
        public override void Process(Product request)
        {
            if (request.ProposedAmount <= 4500)
            {
                Console.WriteLine($"{this.GetType().Name} approved: " +
                    $"{request.RequestType}");
            }
            else
            {
                Console.WriteLine("Purchase request " +
                    "requires a Bank Loan !");
            }
        }
    }
}

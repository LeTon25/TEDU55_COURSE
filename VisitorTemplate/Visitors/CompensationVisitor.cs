using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorTemplate.Elements;

namespace VisitorTemplate.Visitors
{
    public class CompensationVisitor : IVisitor
    {
        public decimal TotalCompensation { get; private set; } = 0;
        public void Visit(BackOfficeEmployee e)
        {
            TotalCompensation += e.Salary + e.Bonus;
        }
        public void Visit(SalesEmployee e)
        {
            TotalCompensation += e.Salary + e.Commission;
        }
    }
}

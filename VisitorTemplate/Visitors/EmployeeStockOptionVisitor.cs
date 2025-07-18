using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorTemplate.Elements;

namespace VisitorTemplate.Visitors
{
    public class EmployeeStockOptionVisitor : IVisitor
    {
        public decimal TotalUnit { get; private set; } = 0;
        public void Visit(BackOfficeEmployee e)
        {
            var totalCompensation = e.Salary + e.Bonus;
            TotalUnit += totalCompensation > 100000 ? 1000 : 500;

        }

        public void Visit(SalesEmployee e)
        {
            var totalCompensation = e.Salary + e.Commission;
            TotalUnit += totalCompensation > 100000 ? 1000 : 500;
        }
    }
}

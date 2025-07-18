using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorTemplate.Visitors;

namespace VisitorTemplate.Elements
{
    public class SalesEmployee : Employee, IElement
    {
        public decimal Commission { get; set; }
        public SalesEmployee(string name, decimal salary, decimal commission) : base(name, salary)
        {
            Commission = commission;
        }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}

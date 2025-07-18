using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorTemplate.Elements;

namespace VisitorTemplate.Visitors
{
    public interface IVisitor
    {
        void Visit(BackOfficeEmployee e);
        void Visit(SalesEmployee e);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorTemplate.Visitors;

namespace VisitorTemplate.Elements
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    public abstract class BaseApprover : IHandler
    {

        protected IHandler _nextHandler;

        public void SetTheNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void Process(Product request);
    }
}

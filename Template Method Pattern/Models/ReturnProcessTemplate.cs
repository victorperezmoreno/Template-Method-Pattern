using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Models
{
    //Abstract template to be overriden by the Faulty and NoQuibbles subclasses
    public abstract class ReturnProcessTemplate
    {
        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder);
        protected abstract void CalculateRefundFor(ReturnOrder returnOrder);

        public void Process(ReturnOrder returnOrder)
        {
            GenerateReturnTransactionFor(returnOrder);
            CalculateRefundFor(returnOrder);
        }
    }

}

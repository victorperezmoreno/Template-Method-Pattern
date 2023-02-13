using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Models
{
    public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid;
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            //Logic to put items back into stock...
            throw new NotImplementedException();
        }
    }
}

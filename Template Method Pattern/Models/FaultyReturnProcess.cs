using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Models
{
    public class FaultyReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost;
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            //Logic to send item back to manufacturer
            throw new NotImplementedException();
        }
    }
}

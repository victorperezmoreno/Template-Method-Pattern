using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Models
{
    public class ReturnServicecs
    {
        //This is the class that makes the calls to the Factory pattern and subclasses that perform the updates when returning an item
        public void Process(ReturnOrder returnOrder)
        {
            ReturnProcessTemplate returnProcess = new ReturnProcessFactory().CreateFrom(returnOrder.Action);
            returnProcess.Process(returnOrder);
            //Logic to refund the money back to the customer
        }
    }
}

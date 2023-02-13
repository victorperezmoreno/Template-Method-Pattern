using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Method_Pattern.Models
{
    public class ReturnProcessFactory
    {
        public ReturnProcessTemplate CreateFrom(ReturnAction returnAction)
        {
            switch (returnAction)
            {
                case ReturnAction.FaultyReturn:
                    return new FaultyReturnProcess();
                case ReturnAction.NoQuibblesReturn:
                    return new NoQuibblesReturnProcess();
                default:
                    throw new ApplicationException("No process template defined for Return action of " + returnAction.ToString());
            }
        }
    }
}

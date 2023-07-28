using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Pattern
{
    public class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }

        public override string Operation()
        {
             return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationIImplementation();
        }
    }
}
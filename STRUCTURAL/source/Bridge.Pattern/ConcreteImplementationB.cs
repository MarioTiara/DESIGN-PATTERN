using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Pattern
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationIImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}
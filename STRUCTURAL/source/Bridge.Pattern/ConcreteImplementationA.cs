using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Pattern
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationIImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
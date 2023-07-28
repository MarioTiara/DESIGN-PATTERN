using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.Pattern
{
    public class Abstraction
    {
        protected IImplementation _implementation;
        public Abstraction(IImplementation implementation){
            this._implementation=implementation;
        }

        public virtual string Operation(){
            return "Abstract: Base operation with:\n" + 
                _implementation.OperationIImplementation();
        }
    }
}
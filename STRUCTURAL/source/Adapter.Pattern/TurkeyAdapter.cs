using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter.Pattern
{
    public class TurkeyAdapter : Duck
    {
        private readonly Turkey turkey;
        public TurkeyAdapter(Turkey turkey){
            this.turkey=turkey;
        }
        public void fly()
        {
            for (int i=0; i<5;i++) turkey.fly();
        }

        public void quack() => turkey.gobble();
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Factory
{
    public class SeaLogistics : Logistic
    {
        public override ITransport createTransport()
        {
            return new Ship();
        }
    }
}
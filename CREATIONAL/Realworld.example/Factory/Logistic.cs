using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realworld.example.Factory
{
    public abstract class Logistic
    {
        public abstract ITransport createTransport();
        public string planDelivery(){
            ITransport transport=createTransport();
            return $"Logistic will be transported by {transport.deliver()}";
        }
    }
}
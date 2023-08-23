using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.Modern
{
    public class ModernChair : IChair
    {
        public bool HasLegs()=>false;

        public string SitOn()=>"Modern Chair";
    }
}
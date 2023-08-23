using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.Modern
{
    public class ModernTable : ITable
    {
        public bool HasLegs()=>false;

        public string Shape()=>"Oval";
    }
}
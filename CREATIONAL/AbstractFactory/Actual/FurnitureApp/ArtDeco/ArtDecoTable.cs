using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureApp.ArtDeco
{
    public class ArtDecoTable : ITable
    {
        public bool HasLegs()=>true;

        public string Shape()=>"Abstract";
    }
}
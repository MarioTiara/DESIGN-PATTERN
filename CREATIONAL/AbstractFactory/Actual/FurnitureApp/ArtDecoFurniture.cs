using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureApp.ArtDeco;

namespace FurnitureApp
{
    public class ArtDecoFurniture : IFurnitureFactory
    {
        public IChair CreateChair()=>new ArtDecoChair();

        public ITable CreateTable()=>new ArtDecoTable();
    }
}
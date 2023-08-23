using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureApp.Modern;

namespace FurnitureApp
{
    public class ModernFuniture : IFurnitureFactory
    {
        public IChair CreateChair()=> new ModernChair();

        public ITable CreateTable()=>new ModernTable();
    }
}
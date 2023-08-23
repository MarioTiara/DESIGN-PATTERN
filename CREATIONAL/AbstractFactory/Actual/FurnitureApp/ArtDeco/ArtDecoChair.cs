using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FurnitureApp;

namespace FurnitureApp.ArtDeco
{
    public class ArtDecoChair : IChair
    {

        public bool HasLegs()=>true;

        public string SitOn()=>"ArtDeco Chair";
    }
}
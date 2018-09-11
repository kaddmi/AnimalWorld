using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Owl : Animal, IWild
    {
        public MoveKind MoveKind { set; get; }
        public Predation Predation { set; get; }
        public string Breed { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Snake : Animal, IWild
    {
        public MoveKind MoveKind { set; get; }
        public Predation Predation { set; get; }
        public Toxicity Toxicity { set; get; } 
        
    }
    enum Toxicity
    {
        None,
        Paralyzing,
        Fatal
    }
}

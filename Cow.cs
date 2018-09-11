using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Cow : Animal, IFeed
    {
        public Products Products { set; get; }
        public LevelOfProfit Profit { set; get; }
        public float Weight { set; get; }
    }
}

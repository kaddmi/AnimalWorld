using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Chicken : Animal, IFeed
    {
        public Products Products { set; get; }
        public LevelOfProfit Profit { set; get; }
        public int EggsPerDay { set; get; }
    }
}

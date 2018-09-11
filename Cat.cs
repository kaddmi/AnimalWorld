using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Cat : Animal, IDomestic
    {
        public Voice Voice { set; get; }
        public Fur Fur { set; get; }
        public string Breed { set; get; }
        public Character Character { set; get; }
    }
    enum Character
    {
        Kind,
        Evil
    }
}

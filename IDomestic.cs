using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    interface IDomestic : IAnimal
    {
        Fur Fur { set; get; }
        Voice Voice { set; get; }
        string Breed { set; get; }
    }
    enum Fur
    {
        None,
        Short,
        Long
    }
    enum Voice
    {
        Meow,
        Bark
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    interface IWild : IAnimal
    {
        MoveKind MoveKind { set; get; }
        Predation Predation { set; get; }
    }
    enum MoveKind
    {
        Fly,
        Float,
        Run
    }
    enum Predation
    {
        Herbivourus,
        Carnivourus
    }
}

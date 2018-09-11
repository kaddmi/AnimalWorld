using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Dog : Animal, IDomestic
    {
        public Voice Voice { set; get; }
        public Fur Fur { set; get; }
        public string Breed { set; get; }
        public LevelOfTraining Training { set; get; }
    }
    enum LevelOfTraining
    {
        None,
        Little,
        High
    }
}

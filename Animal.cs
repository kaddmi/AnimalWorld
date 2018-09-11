using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Animal : IAnimal
    {
        public string Name { set; get; }
        public int Age { set; get; }
    }
}

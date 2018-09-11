using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalWorld
{
    class Group<T> where T : IAnimal
    {
        public List<T> AnimalGroup { set; get; }
        public Group()
        {
            AnimalGroup = new List<T>();
        }
    }

}

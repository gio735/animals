using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public abstract class Animal
    {
        protected static int IDMaker { get; set; }
        public int ID { get; protected set; }
        public string Name { get; set; }
        public string Breed { get; protected set; }
        public bool Owned { get; set; }
    }
}

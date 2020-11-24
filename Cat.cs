using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public class Cat : Animal
    {
        public Cat(string breed = "unknown")
        {
            ID = ++IDMaker;
            Breed = breed;
        }
    }
}

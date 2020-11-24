using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public class Cat : Animal
    {
        public Cat(Breed breed)
        {
            ID = ++IDMaker;
            Breed = breed;
        }
    }
}

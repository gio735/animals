using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public class Dog : Animal
    {
        public Dog(string breed = "unknown")
        {
            ID = ++IDMaker;
            Breed = breed;
        }
    }
}

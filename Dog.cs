﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public class Dog : Animal
    {
        public Dog(Breed breed)
        {
            ID = ++IDMaker;
            Breed = breed;
        }
    }
}

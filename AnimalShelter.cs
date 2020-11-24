using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public static class AnimalShelter
    {
        public static int TotalAnimals { get; private set; }
        public static int Available { get; set; }
        public static int Unavailable { get; set; }
        public static int Dogs { get; private set; }
        public static int Cats { get; private set; }
        public static List<Animal> Animals { get; private set; }

        static AnimalShelter()
        {
            Animals = new List<Animal>();
        }
        public static void Search() //looking around to find abandoned pets and bring to shelter
        {
            Random rnd = new Random();
            
            for (int amount = rnd.Next(1, 6); amount > 0; amount--)
            {
                int animal = rnd.Next(1, 3);
                if (animal == 1)
                {
                    Animals.Add(new Dog((Breed)rnd.Next(0, 5)));
                    Dogs++;
                    TotalAnimals++;
                    Available++;
                }
                else
                {
                    Animals.Add(new Cat((Breed)rnd.Next(5, 10)));
                    Cats++;
                    TotalAnimals++;
                    Available++;
                }
            }
        }
    }
    public enum Breed
    {
        Auggie,
        Bloodhound,
        Chug,
        Dachshund,
        ShibaInu,

        Abyssinian,
        Birman,
        Cymric,
        Havana,
        Korat
    }
}

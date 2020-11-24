using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Animalz
{
    public class Person
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public List<Animal> Pets { get; private set; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            Pets = new List<Animal>();
        }
        public void Abandon(int iD) //returns pet back to shelter
        {
            foreach (Animal pet in Pets)
            {
                if (pet.ID == iD) //check if person have such pet
                {
                    pet.Owned = false;
                    Pets.Remove(pet);
                    AnimalShelter.Available++;
                    AnimalShelter.Unavailable--;
                    return;
                }
            }
            Console.WriteLine("Couldn't find pet with such ID");
        }
        public void Adopt(int iD, string name) //adopts pet from shelter
        {
            foreach (Animal animal in AnimalShelter.Animals)
            {
                if (animal.ID == iD) //check if animal exist
                {
                    if (!animal.Owned) //check if animal is available or not
                    {
                        animal.Name = name;
                        animal.Owned = true;
                        Pets.Add(animal);
                        AnimalShelter.Available--;
                        AnimalShelter.Unavailable++;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Animal u have requested is already owned");
                        Thread.Sleep(2000);
                    }
                    
                }    
            }
            Console.WriteLine("Couldn't find animal with such ID");
        }
    }
}

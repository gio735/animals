using System;
using System.Collections.Generic;
using System.Text;

namespace Animalz
{
    public static class Screen
    {
        public static ScreenModes ScreenMode { get; set; } //decides what info we see. shelter or pets, maybe more later

        public static void GetShelterInfo()  //print shelter information in console
        {
            Console.WriteLine(new string('-', 80));
            foreach (Animal animal in AnimalShelter.Animals)
            {
                string available = "";
                if (animal.Owned) //check if animal can be adopted or not
                {
                    available = "Unavailable";
                }
                else
                {
                    available = "available";
                }
                if (animal is Dog) //texts if animal is dog or cat
                {
                    Console.WriteLine($"Dog: ID - {animal.ID}.\n");
                    Console.WriteLine($"Breed: {animal.Breed}.\n");
                    Console.WriteLine($"Status: {available}.\n");
                    Console.WriteLine(new string('-', 80));
                }
                else
                {
                    Console.WriteLine($"Cat: ID - {animal.ID}.\n");
                    Console.WriteLine($"Breed: {animal.Breed}.\n");
                    Console.WriteLine($"Status: {available}.\n");
                    Console.WriteLine(new string('-', 80));
                }
            }
            Console.WriteLine($"Animals:\n\nDogs - {AnimalShelter.Dogs}.\n\nCats - {AnimalShelter.Cats}.\n\nAvailable - {AnimalShelter.Available}.\n\nUnavailable - {AnimalShelter.Unavailable}.\n\nTotal - {AnimalShelter.TotalAnimals}.\n\n");//info about amount
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Write \"my pets\" to see your pets shelter, \"adopt\" to adopt one of animal(s) or \"exit\" to quit code.");
        }
        public static void GetPetsInfo(Person person) //print pet(s) info in console
        {
            Console.Clear();
            if (person.Pets.Count == 0) //message if person have not any pet
            {
                
                Console.WriteLine($"There is no pet owned by {person.Name}\n");
                Console.WriteLine("Write \"to shelter\" and adopt some pets");
                return;
            }
            foreach (Animal pet in person.Pets)
            {
                if (pet is Dog) //check if its dog or cat
                {
                    Console.WriteLine($"Dog: ID - {pet.ID}.\n");
                    Console.WriteLine($"Name: {pet.Name}.\n");
                    Console.WriteLine($"Breed: {pet.Breed}.\n");
                    Console.WriteLine(new string('-', 80));
                }
                else
                {
                    Console.WriteLine($"Cat: ID - {pet.ID}.\n");
                    Console.WriteLine($"Name: {pet.Name}.\n");
                    Console.WriteLine($"Breed: {pet.Breed}.\n");
                    Console.WriteLine(new string('-', 80));
                }
            }
            Console.WriteLine("Write \"to shelter\" to visit animal shelter, \"abandon\" to abandon one of ur pet(s) :/ or \"exit\" to quit code.");
        }

        public static void GetScreen(Person person) //print things depending to 'screenmode'
        {
            if (ScreenMode == ScreenModes.ShelterList)
            {
                Console.Clear();
                GetShelterInfo();
            }
            else if (ScreenMode == ScreenModes.PetList)
            {
                Console.Clear();
                GetPetsInfo(person);
            }
        }
        //changing screenmodes
        public static void ToShelter()
        {
            ScreenMode = ScreenModes.ShelterList;
        }
        public static void ToPets()
        {
            ScreenMode = ScreenModes.PetList;
        }
    }
    public enum ScreenModes
    {
        ShelterList,
        PetList
    }
}

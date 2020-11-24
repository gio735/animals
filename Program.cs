using System;

namespace Animalz
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter.Search();
            bool takingName = true;
            Console.WriteLine("Choose your name: ");
            string name = "";
            while (takingName)
            {
                name = Console.ReadLine().Trim().Replace(" ", ""); //takes name of person
                if (name != "")
                {
                    takingName = false;
                }
                else
                {
                    Console.CursorLeft = 0;
                    Console.CursorTop--;
                    Console.Write("                                               ");
                    Console.CursorLeft = 0;
                }
            }
            Console.Clear();
            Console.Write("Choose your lastname or press enter: "); 
            string lastName = Console.ReadLine().Trim().Replace(" ", ""); //takes last name of person or not
            Person person = new Person(name, lastName);
            bool active = true;
            int timer = 0; //every 5 turn, search command from AnimalShelter is running
            while (active)
            {
               
                Screen.GetScreen(person);
                string command = Console.ReadLine().Trim().Replace(" ", ""); //takes command
                Commands.TryParse(command, true, out Commands enumousCommand);
                if (enumousCommand == Commands.Adopt) //check whats command and execute
                {
                    bool takingID = true;
                    Console.Clear();
                    Console.WriteLine("Whats ID of pet u want to adopt?");
                    while (takingID)
                    {
                        bool wasParsed = int.TryParse(Console.ReadLine(), out int parsedID);
                        if (wasParsed)
                        {
                            Console.Clear();
                            Console.WriteLine("Whats name of ur pet?");
                            person.Adopt(parsedID, Console.ReadLine());
                            takingID = false;
                        }
                        else
                        {
                            Console.CursorLeft = 0;
                            Console.CursorTop--;
                            Console.Write("                                     ");
                            Console.CursorLeft = 0;
                        }
                    }
                }
                else if (enumousCommand == Commands.Abandon)
                {
                    bool takingID = true;
                    Console.Clear();
                    Console.WriteLine("Whats ID of pet u want to abandon?");
                    while (takingID)
                    {
                        bool wasParsed = int.TryParse(Console.ReadLine(), out int parsedID);
                        if (wasParsed)
                        {
                            person.Abandon(parsedID);
                            takingID = false;
                        }
                        else
                        {
                            Console.CursorLeft = 0;
                            Console.CursorTop--;
                            Console.Write("                                     ");
                            Console.CursorLeft = 0;
                        }
                    }
                }
                else if (enumousCommand == Commands.ToShelter)
                {
                    Screen.ToShelter();
                }
                else if (enumousCommand == Commands.MyPets)
                {
                    Screen.ToPets();
                }
                else if(enumousCommand == Commands.Exit)
                {
                    active = false;
                }
                else
                {
                    Console.CursorLeft = 0;
                    Console.CursorTop--;
                    Console.Write("                                          ");
                    Console.CursorLeft = 0;
                }
                timer++;
                if (timer == 5)
                {
                    AnimalShelter.Search();
                    timer = 0;
                }
            }
        }
    }
    public enum Commands
    {
        None,
        Adopt,
        Abandon,
        ToShelter,
        MyPets,
        Exit
    }
}

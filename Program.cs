using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class Program
    {
        //Main() method https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line
        static void Main(string[] args)
        {
            // DisplayGreeting();
            Console.WriteLine("Welcome to Jurassic Park!");
            //Test Code
            // DinosaurDatabase.Add("carnivore", "Godzilla", 328000000, 1);
            // DinosaurDatabase.Add("carnivore", "T-Rex", 13000, 1);
            // DinosaurDatabase.Add("carnivore", "Steve", 8000, 2);
            // DinosaurDatabase.Add("herbivore", "Sarah", 12500, 3);
            // DinosaurDatabase.Add("herbivore", "Buttons", 2, 100);

            // DinosaurDatabase.Summary();

            // DinosaurDatabase.Remove("Godzilla");

            // DinosaurDatabase.Transfer("Buttons", 1000);

            // DinosaurDatabase.ViewDinos("Name");
            // DinosaurDatabase.ViewDinos("EnclosureNumber");

            // DinosaurDatabase.Summary();
            bool keepGoing = true;
            string input = "";

            while (keepGoing)
            {
                Console.WriteLine("***************************************************");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("(A)dd a dino.");
                Console.WriteLine("(V)iew a the dinos in specified order.");
                Console.WriteLine("(T)ransfer a dino");
                Console.WriteLine("(R)emove a dino or (Q)uit.");
                Console.WriteLine("(S)ummarize the dinos");
                Console.WriteLine("(Q)uit? ");

                input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case "A":
                        string newDiet = "";
                        string newName = "";
                        int newWeight = 0;
                        int newEnclosure = 0;
                        Console.WriteLine("Is your dino a (H)erbivore or (C)arnivore");
                        string response = Console.ReadLine().ToUpper();
                        if (response == "H")
                        {
                            newDiet = "herbivore";
                        }
                        else if (response == "C")
                        {
                            newDiet = "carnivore";
                        }
                        else
                        {
                            Console.WriteLine("Invalid diet type!");
                            break;
                        }

                        Console.WriteLine("What is your new dino's name? ");
                        newName = Console.ReadLine();

                        Console.WriteLine("What is the weight of your dino in pounds? ");
                        newWeight = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Which enclosure number do you want to place {newName} in? ");
                        newEnclosure = int.Parse(Console.ReadLine());

                        DinosaurDatabase.Add(newDiet, newName, newWeight, newEnclosure);
                        break;

                    case "V":
                        Console.WriteLine("Order by (N)ame or (E)nclosure? ");
                        string orderInput = Console.ReadLine();
                        if (orderInput.ToUpper() == "N")
                        {
                            DinosaurDatabase.ViewDinos("Name");
                        }
                        else
                        {
                            if (orderInput.ToUpper() == "E")
                            {
                                DinosaurDatabase.ViewDinos("Enclosure");
                            }
                        }
                        break;
                    case "T":
                        //user input specifying the dino you want to transfer
                        Console.WriteLine("What is the name of the dino you would like to transfer? ");
                        string transferDino = Console.ReadLine();
                        //user input specifying the dino enclosure
                        Console.WriteLine("Which enclosure number should we move the dino into? ");
                        int newTransferEnclosure = int.Parse(Console.ReadLine());

                        Dinosaur dinoBeingTransferred = DinosaurDatabase.Transfer(transferDino, newTransferEnclosure);
                        if (dinoBeingTransferred != null)
                        {
                            Console.WriteLine($"{dinoBeingTransferred.Name} has been transferred.");
                        }
                        else
                        {
                            Console.WriteLine("This dino does not exist.");
                        }
                        break;
                    case "R":
                        Console.WriteLine("What is the name of the dino you are going to remove? ");
                        Dinosaur dinoToBeRemoved = DinosaurDatabase.Remove(Console.ReadLine());
                        if (dinoToBeRemoved != null)
                        {
                            Console.WriteLine($"{dinoToBeRemoved.Name} has being removed.");
                        }
                        else
                        {
                            Console.WriteLine("This dino does not exist in the current database.");
                        }
                        break;

                    case "S":
                        DinosaurDatabase.Summary();
                        break;

                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }

            }
        }
    }
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }//This will be "carnivore" or "herbivore"
        public DateTime AcquisitionDate { get; set; }//This will default to the current time when the dinosaur is created
        public int Weight { get; set; }//How heavy the dinosaur is in pounds.
        public int EnclosureNumber { get; set; }//the number of the enclosure the dinosaur is in
        //building a constructor
        public Dinosaur(string diet, string name, int weight, int enclosureNumber)
        {
            DietType = diet;
            Name = name;
            AcquisitionDate = DateTime.Now;
            Weight = weight;
            EnclosureNumber = enclosureNumber;
        }
        public void Description()
        {
            Console.WriteLine($"{Name} is a {DietType} that was acquired {AcquisitionDate} and weighs {Weight} pounds and lives in pen number {EnclosureNumber}!");
        }
    }
    static class DinosaurDatabase
    {
        static List<Dinosaur> dinos = new List<Dinosaur>() { };
        public static void ViewDinos(string orderBy)
        {
            if (dinos.Count == 0)
            {
                Console.WriteLine("Who let the dinos out?!");
                return;
            }
            if (orderBy == "Name")
            {
                dinos = dinos.OrderBy(dino => dino.Name).ToList<Dinosaur>();
            }
            else
            if (orderBy == "Enclosure")
            {
                dinos = dinos.OrderBy(dino => dino.EnclosureNumber).ToList<Dinosaur>();
            }

            dinos.ForEach(dino => dino.Description());
            Console.WriteLine("==============================================");
        }
        public static Dinosaur Add(string diet, string name, int weight, int enclosureNumber)
        {
            Dinosaur newDino = new Dinosaur(diet, name, weight, enclosureNumber);
            dinos.Add(newDino);
            return newDino;
        }
        public static Dinosaur Remove(string name)
        {
            Dinosaur dinoToRemove = dinos.FirstOrDefault(dino => dino.Name.ToLower() == name);
            if (dinoToRemove != null)
            {
                dinos.Remove(dinoToRemove);
                Console.WriteLine("Dino removed!");
            }
            return dinoToRemove;
        }
        public static Dinosaur Transfer(string name, int newEnclosure)
        {
            Dinosaur transferDino = dinos.FirstOrDefault(dino => dino.Name.ToLower() == name);
            if (transferDino != null)
            {
                transferDino.EnclosureNumber = newEnclosure;
                Console.WriteLine("Dino Updated");
            }
            return transferDino;
        }
        public static void Summary()
        {
            int herbCount = dinos.Where(dinos => dinos.DietType == "herbivore").Count();
            int carnCount = dinos.Where(dinos => dinos.DietType == "carnibore").Count();
            Console.WriteLine($"There are {herbCount} herbivores and {carnCount} carnivores in our park.");
        }
    }
}

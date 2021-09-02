using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class Program
    {
        static void Main(string[] args)
        {
            // DisplayGreeting();
            Console.WriteLine("Welcome to Jurassic Park!");
            //Test Code
            DinosaurDatabase.Add("carnivore", "Godzilla", 328000000, 1);
            DinosaurDatabase.Add("carnivore", "T-Rex", 13000, 1);
            DinosaurDatabase.Add("carnivore", "Steve", 8000, 2);
            DinosaurDatabase.Add("herbivore", "Sarah", 12500, 3);
            DinosaurDatabase.Add("herbivore", "Buttons", 2, 100);

            DinosaurDatabase.ViewDinos("Name");
            DinosaurDatabase.ViewDinos("EnclosureNumber");

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
    }
}

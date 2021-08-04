using System;
using System.Collections.Generic;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public string DinoDescription()
        {
            //print out a description of the dinosaur to include all the properties. 
            //Create an output format of your choosing. Feel free to be creative.
            return Name + DietType + AcquisitionDate + Weight + EnclosureNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jurassic Park");
        }
    }
}

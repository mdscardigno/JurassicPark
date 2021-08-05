using System;
using System.Collections.Generic;
using System.Linq;

namespace JurassicPark
{
    class Dinosaur
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
    }
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("🦕 Welcome to Jurassic Park 🦖");
            Console.WriteLine("*****************************************");
            Console.WriteLine();
        }
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);
            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, but your input is invalid. Please try again.");
                return 0;
            }
        }
        public string DinoDescription()
        {
            string description = Name + DietType + AcquisitionDate + Weight + EnclosureNumber;
            //print out a description of the dinosaur to include all the properties. 
            //Create an output format of your choosing. Feel free to be creative.
            return description;
        }
        static void Main(string[] args)
        {
            var dinosaurs = new List<Dinosaur>();
            var dinosour = new Dinosaur();
            var dinoDescription = DinoDescription();

            DisplayGreeting();

            //should we keep displaying the menu?
            var keepWorking = true;
            //while the user hasn't quit
            while (keepWorking)
            {
                Console.WriteLine();
                Console.WriteLine("What do you want to do? \n🔍(V)iew the summary of a 🦕, \n➕(A)dd a 🦕\n🗑 (R)emove a 🦕\n𝌡 (T)ransfer a 🦕\n🛑(Q)uit\n: ");
                var option = Console.ReadLine().ToUpper();
                if (option == "V")
                {
                    // READ(out of CREATE -READ - UPDATE - DELETE)
                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine($"{dinosaur.Name} is in enclosure {dinosaur.EnclosureNumber} and it was acquired on {dinosaur.AcquisitionDate}; it is a {dinosaur.DietType} dinosaur and weights {dinosaur.Weight} pounds.");
                    }
                }
                else
                if (option == "R")
                {
                    // Get the dinosaur name we are searchign for
                    var nameOfDinoToSearchFor = PromptForString("What's the dino's name you looking for? ");
                    // Search the dinosaur database to see if it exist!
                    Dinosaur foundDino = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinoToSearchFor);
                    // If we found a dinosaur
                    if (foundDino != null)
                    {
                        //  - We did find the dinosaur
                        //  - Show the details for the dinosaur
                        {
                            Console.WriteLine($"{foundDino.Name} is in enclosure {foundDino.EnclosureNumber} and was acquired on {foundDino.AcquisitionDate}; it is a{foundDino.DietType} dinosaur and weights {foundDino.Weight} pounds.");
                        }
                        //  - Ask to confirm "Are you sure you want to delete the dinosaur name specified?"
                        var confirm = PromptForString($"Are you sure you want to delete {foundDino.Name}? [Y/N] ").ToUpper();
                        //  - If they say no
                        if (confirm == "N")
                        {
                            //    - do nothing
                        }
                        else
                        {
                            //  - If user say yes
                            //    - Delete the dinosaur name specified
                            dinosaurs.Remove(foundDino);
                        }

                    }
                    else
                    {
                        //  Show that the person doesn't exist
                        Console.WriteLine("No such dinosaur exists!");
                    }
                }//end of option Delete
                else
                if (option == "T")
                {
                    var nameOfDinoToTransfer = PromptForString("What's the dino's name you looking for? ");
                    //find the dino
                    Dinosaur foundDino = dinosaurs.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinoToTransfer);
                    //find the enclosure number

                    //if enclosure number exists, display and ask the user to comfirm if the do want to transfer the dino

                    //if yes
                    //  continue
                    //if no
                    //  do nothing
                }
                else
                if (option == "Q")
                {
                    keepWorking = false;
                }
                else
                {
                    // Make a new dinosaur object
                    var dinosaur = new Dinosaur();
                    // Prompt for values and save them in the dinosaur's properties
                    dinosaur.Name = PromptForString("What is the type of dinosaur? ");
                    dinosaur.DietType = PromptForString("Is the dinosaur carnivore or herbivore? ");
                    dinosaur.Weight = PromptForInteger("How heavy is the dinosaur (in pounds)? ");
                    dinosaur.AcquisitionDate = DateTime.Now;
                    dinosaur.EnclosureNumber = PromptForInteger("Specify the enclosure number where the dinosaur is/will be at? ");

                    // Add the dinosaur to the list of dinosaurs
                    dinosaurs.Add(dinosaur);
                }
            }// end of the `while` statement

        }
    }
}

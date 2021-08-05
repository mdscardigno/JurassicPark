# JurassicPark

<!--
#PEDAC

CRUDE Create, Read, Update, and Edit
##P: Restating Problem
My console application will administer the data about the dinosaurs in the zoo.
Each of the dinosaurs in our zoo will be described as having a Name, DietType, AcquisitionDate, Weight as well as the enclosure where the dino will be placed at.
The user will be able to do the following:
-View or access the list of dinosaurs in the zoo.
-Add a new Dinosaur to the list of dinosaurs.
  *Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
  Dino names must be unique per each dino and not allow for duplicate.
-User will be able to remove a dinosaur from the list at a time.
-User will be able to transfer a dino from one enclosure to another. Two enclosures cannot contain the same dino name.
-User will be able to access a summary displaying the number of carnivores dinosaurs and the number of herbivores dinosaurs.


Welcome to Jurassic Park
What would you like to do? (V)iew, (A)dd, (R)emove, (T)Transfer, (S)Summary, or (Q)uit

Requirements
-[x]Build Dinosaur class with properties Name, DietType, AcquisitionDate, Weight and EnclosureNumber.
-[]Add a method Description to your class to print out a description of the dinosaur to include all the properties. Create an output format of your choosing. Feel free to be creative.
-[]Keep track of your dinosaurs in a List<Dinosaur>.
-[]When the console application runs, it should let the user choose one of the following actions:
  *[]View
    **This command will show the all the dinosaurs in the list, ordered by WhenAcquired. If there aren't any dinosaurs in the park then print out a message that there aren't any.
  *[]Add
    **This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
  *[]Remove
    **This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
  *[]Transfer
    **This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
  *[]Summary
    **This command will display the number of carnivores and the number of herbivores.
  *Quit
    **This will stop the program
-[]
##E: Example
DateTime provided by the code when created. var dinoList = dates.OrderBy(d => d);
SortBy
Jurassic Park Dino Interface
-Add new dino
  What is the name of the dino?
  How much does it weight?
  When was it purchased/donated?
  Which enclosure is the dino going to be placed at within the zoo/park?
-Edit/Update dino info
  What would you like to change? (V)iew, (A)dd, (R)emove, (T)Transfer, (S)Sumary, (Q)uit
  -Remove dino from the inventory of dinos. Specify which enclosure number will be available for any new dinos to be added in the future.
-Quit
Description: Console.Write($"{name} is a {dietType} that weights {weight} and was purchased/donated on {AcquisitionDate} and it is currently located at enclosure number {enclosure}");

Dinosaur List
List<Dinosaur> to keep track of the dinosaurs
A- Herbivorous dinosaurs
  1. Aardonyx.
  2. Achelousaurus.
  3. Aegyptosaurus.
  4. Agilisaurus.
  5. Alamosaurus.
  6. Albertaceratops.
  7. Amargasaurus.
  8. Ammosaurus.

B- Abelisaurus.
  1. Achillobator.
  2. Acrocanthosaurus. Acrocantho-saurus.
  3. Afrovenator.
  4. Albertosaurus.
  5. Alectrosaurus.
  6. Alioramus.
  7. Allosaurus.
##D: Data
  >DateTime
  >Collection
  >List
  >DinoName ToUpperCase();
  >Description about each dinosaur

##A: Algorithm


##C: Code

-->

using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            var birdOne = new Bird();
            birdOne.Nocturnal = true;
            birdOne.Age = 2;
            birdOne.BeakSize = "small";
            birdOne.LandWaterOrAir = "land";
            birdOne.LegCount = 2;
            birdOne.Habitat = "tree";


            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var reptileOne = new Reptile();
            reptileOne.Nocturnal = true;
            reptileOne.Age = 8;
            reptileOne.LegCount = 4;
            reptileOne.LandWaterOrAir = "water";
            reptileOne.IsColdBlooded = true;
            reptileOne.Habitat = "water";
            
            



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             * Creatively display the class member values
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var animals = new Animal[] { birdOne, reptileOne };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Nocturnal} they need to sleep at night.");
                Console.WriteLine($"It's has {animal.LegCount} legs.");
                Console.WriteLine($"Also it lives by {animal.LandWaterOrAir}.");
                Console.WriteLine($"It's {animal.Age} years old.");
                Console.WriteLine();
            }
        } 
    }
}

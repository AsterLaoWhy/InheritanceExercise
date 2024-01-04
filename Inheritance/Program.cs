using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE
            // give this class 4 members that all Animals have in common DONE


            // Create a class Bird DONE
            // give this class 4 members that are specific to Bird Done
            // Set this class to inherit from your Animal Class DONE

            // Create a class Reptile DONE
            // give this class 4 members that are specific to Reptile Done
            // Set this class to inherit from your Animal Class Done

                var hedwig = new Bird();
                hedwig.IsNocturnal = true;
                hedwig.CanFly = true;
                hedwig.Cry = "I'll always save you Harry";
                hedwig.HasFeathers = true;
                hedwig.HasEyes = true;
                hedwig.IsHeterotrophic = true;
                hedwig.ReproductionType = "Eggs";
                hedwig.HasCellWalls = false;
                Console.WriteLine($"Hedwig is a bird from Harry Potter. It's {hedwig.IsNocturnal} she is nocturnal and {hedwig.HasEyes} she has eyes.\n It's also {hedwig.CanFly} she can fly and {hedwig.HasFeathers} she has feathers. \n" +
                    $" It's {hedwig.IsHeterotrophic} she needs a male owl and has babies from {hedwig.ReproductionType}. \n It's {hedwig.HasCellWalls} her cells have cell walls. Her line in the books is {hedwig.Cry}. \n");


                var nagini = new Reptile();
                nagini.HasScales = true;
                nagini.IsColdBlooded = true;
                nagini.IsVenomous = true;
                nagini.HasLegs = false;
                nagini.HasEyes = true;
                nagini.IsHeterotrophic = true;
                nagini.ReproductionType = "Eggs";
                nagini.HasCellWalls = false;
                Console.WriteLine($"Nagini is a snake from Harry Potter. It's {nagini.HasScales} she has scales and {nagini.HasEyes} she has eyes.\n It's also {nagini.IsVenomous} her bite can send the little prince back home" +
                    $" and {nagini.HasLegs} she has legs -\n despite running in to protect Voldemort (Tom Elvis Jedusor haha).\n It's {nagini.IsHeterotrophic} she needs a male snake and has babies from {nagini.ReproductionType} that aren't scrambled" +
                    $".\n It's {nagini.HasCellWalls} her cells have cell walls. Despite giving her life to save someone from the jailhouse rock, it's {nagini.IsColdBlooded} she is cold blooded.");

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class DONE
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            Console.ReadLine();
        }
    }
}

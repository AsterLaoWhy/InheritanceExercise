using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
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



            void main() 
            {
                var hedwig = new Bird();
                hedwig.isNocturnal = true;
                hedwig.canFly = true;
                hedwig.cry = "I'll always save you Harry";
                hedwig.hasFeathers = true;
                hedwig.hasEyes = true;
                hedwig.isHeterotrophic = true;
                hedwig.reproductionType = "Eggs";
                hedwig.hasCellWalls = false;
                Console.WriteLine($"Hedwig is a bird from Harry Potter. It's {hedwig.isNocturnal} she is nocturnal and {hedwig.hasEyes} she has eyes.\n It's also {hedwig.canFly} she can fly and {hedwig.hasFeathers} she has feathers. \n" +
                    $" It's {hedwig.isHeterotrophic} she needs a male owl and has babies from {hedwig.reproductionType}. \n It's {hedwig.hasCellWalls} her cells have cell walls. Her line in the books is {hedwig.cry}. \n");


                var nagini = new Reptile();
                nagini.hasScales = true;
                nagini.isColdBlooded = true;
                nagini.isVenomous = true;
                nagini.hasLegs = false;
                nagini.hasEyes = true;
                nagini.isHeterotrophic = true;
                nagini.reproductionType = "Eggs";
                nagini.hasCellWalls = false;
                Console.WriteLine($"Nagini is a snake from Harry Potter. It's {nagini.hasScales} she has scales and {nagini.hasEyes} she has eyes.\n It's also {nagini.isVenomous} her bite can send the little prince back home" +
                    $" and {nagini.hasLegs} she has legs -\n despite running in to protect Voldemort (Tom Elvis Jedusor haha).\n It's {nagini.isHeterotrophic} she needs a male snake and has babies from {hedwig.reproductionType} that aren't scrambled" +
                    $".\n It's {nagini.hasCellWalls} her cells have cell walls. Despite giving her life to save someone from the jailhouse rock, it's {nagini.isColdBlooded} she is cold blooded.");
            }
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
            main();
            Console.ReadLine();
        }
    }
}

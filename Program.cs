using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        public static void Main()
        {
// Create an empty HashSet named Showroom that will contain strings.
// Add four of your favorite car model names to the set.
            HashSet<string> Showroom = new HashSet<string>()
            {"BMW", "Mercedes Benz", "Toyota", "Jeep"};

// Print to the console how many cars are in your show room.
            foreach(string model in Showroom){
                Console.WriteLine($"{model}");
            }
// Pick one of the items in your show room and add it to the set again.
            Showroom.Add("BMW");

// Print your showroom again, and notice how there's still only one representation of that model in there.
            foreach(string model in Showroom){
                Console.WriteLine($"{model}");
            }

// Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>()
            {"GM", "Hyundai"};

// Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);

// You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Mercedes Benz");

            foreach(string model in Showroom){
                Console.WriteLine($"new: {model}");
            }


//More Cars


// Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            HashSet<string> Junkyard = new HashSet<string>()
            {"Toyota", "Jeep", "GM", "Hatchback", "Maruthi Suzuki"};

// Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);
            HashSet<string> clone = new HashSet<string>(Showroom);

// Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.
            Junkyard.IntersectWith(clone);

            foreach(string model in Junkyard){
                Console.WriteLine($"junkyard: {model}");
            }

// Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);
            foreach(string model in Showroom){
                Console.WriteLine($"Showroom + Junkyard cars: {model}");
            }
// Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
            Showroom.Remove("Maruthi Suzuki");
            foreach(string model in Showroom){
                Console.WriteLine($"No Maruthi: {model}");
            }











        }
    }
}

using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        // Collecting the added Grazing Fields
        public static void CollectInput(Farm farm, IGrazing animal)
        {

            Utils.Clear();
            // Loop throughh created Facilities and list them by number
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Grazing Field");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            // User Inputted number
            int choice = Int32.Parse(Console.ReadLine());
            // Using the Inputted Number in association with the Facility and adding animal
            farm.GrazingFields[choice].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}
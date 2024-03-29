using System;
using System.Linq;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        // Collecting the added Grazing Fields


             public List<NaturalField> NaturalFields = new List<NaturalField>();

        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Utils.Clear();
            // Loop throughh created Facilities and list them by number
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field ");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the seed where?");

            Console.Write("> ");
            // User Inputted number
            int choice = Int32.Parse(Console.ReadLine());
            // Using the Inputted Number in association with the Facility and adding seed
            farm.NaturalFields[choice-1].AddResource(seed);
            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}
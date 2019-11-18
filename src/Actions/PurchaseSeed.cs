using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class PurchaseSeed {


        public static void CollectInput (Farm seed) {

            //farm refers to every grazing field

            Console.WriteLine ("1. WildFlower");
            Console.WriteLine ("2. Sesame");
            Console.WriteLine ("3. Sunflower");

            Console.WriteLine ();
            Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            //set a string to the number typed in

            switch (Int32.Parse(choice))

            // setting the choice to an integer

            {
                case 1:

                // if the user types in 1 run this

                    ChooseNaturalField.CollectInput(seed, new Wildflower());
                    Console.WriteLine("Wildflowers can only be put in a Natural Field.");
                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;
                case 2:
                    ChoosePlowingField.CollectInput(seed, new Sesame());
                    break;
                case 3:
                    ChooseNaturalField.CollectInput(seed, new Sunflower());
                    break;
                default:
                    break;
            }
        }

    }
}
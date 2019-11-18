using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class PurchaseStock {


        public static void CollectInput (Farm farm) {

            //farm refers to every grazing field

            Console.WriteLine ("1. Cow");
            Console.WriteLine ("2. Ostrich");


           Console.WriteLine ("6. Chicken" );
            Console.WriteLine ("7. Duck" );
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

                    ChooseGrazingField.CollectInput(farm, new Cow());

                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;

                    case 6:
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;

                    case 7:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;

                default:
                    break;
            }
        }

    }
}
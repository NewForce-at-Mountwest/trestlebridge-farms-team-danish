using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {


        public static void CollectInput(Farm farm)
        {

            //farm refers to every grazing field

            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Pig");
            Console.WriteLine("3. Goat");
            Console.WriteLine("4. Ostrich");
            Console.WriteLine("5. Sheep");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            //set a string to the number typed in

            switch (Int32.Parse(choice))

            // setting the choice to an integer

            {
                case 1:

                    // if the user types in 1 run this

                    ChooseGrazingField.CollectInput(farm, new Cow());

                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;

                case 2:

                    // if the user types in 1 run this

                    ChooseGrazingField.CollectInput(farm, new Pig());

                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;

                case 3:

                    // if the user types in 1 run this

                    ChooseGrazingField.CollectInput(farm, new Goat());

                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;
                case 4:

                    // if the user types in 1 run this

                    ChooseGrazingField.CollectInput(farm, new Ostrich());

                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;
                case 5:

                    // if the user types in 1 run this

                    ChooseGrazingField.CollectInput(farm, new Sheep());

                    // from here the application knows you would like to purchase a cow and will then ask where to put it in ChooseGrazingField

                    break;
                default:
                    break;
            }
        }
    }
}
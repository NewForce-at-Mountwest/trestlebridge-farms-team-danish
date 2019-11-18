using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

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
            Console.WriteLine("6. Chicken");
            Console.WriteLine("7. Duck");
            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            //set a string to the number typed in

            switch (Int32.Parse(choice))

            // setting the choice to an integer

            {
                case 1:

                    ChooseGrazingField.CollectInput(farm, new Cow());

                    break;

                case 2:

                    ChooseGrazingField.CollectInput(farm, new Pig());

                    break;

                case 3:

                    ChooseGrazingField.CollectInput(farm, new Goat());

                    break;
                case 4:

                    ChooseGrazingField.CollectInput(farm, new Ostrich());



                    break;

                case 5:

                    ChooseGrazingField.CollectInput(farm, new Sheep());
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
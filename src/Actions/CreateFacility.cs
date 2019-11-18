using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        //navigation select options
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural Field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();
            //add type of field
            switch (Int32.Parse(input))
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("You have created a new Grazing Field");
                    Console.WriteLine("Press Return to Exit");
                    Console.ReadLine();
                    farm.AddGrazingField(new GrazingField());
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("You have created a new Natural Field");
                    Console.WriteLine("Press Return to Exit");
                    Console.ReadLine();
                    farm.AddNaturalField(new NaturalField());
                    break;

                case 5:

                    Console.WriteLine();
                    Console.WriteLine("You have created a new Duck House");
                    Console.WriteLine("Press Return to Exit");
                    Console.ReadLine();
                    farm.AddDuckHouse(new DuckHouse());
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("You have created a new Chicken House!");
                    Console.WriteLine("Press Return to Exit");
                    Console.ReadLine();
                    farm.AddChickenHouse(new ChickenHouse());
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("You have created a new Plowing Field");
                    Console.WriteLine("Press Return to Exit");
                    Console.ReadLine();
                    farm.AddPlowingField(new PlowingField());
                    break;
                default:
                    break;




            }


        }
    }
}
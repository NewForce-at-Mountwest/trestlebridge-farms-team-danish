using System;
using System.Collections.Generic;
using Trestlebridge.Models.Plants;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;


namespace Trestlebridge.Actions
{
    public class PlaceSunflower{

        public static void CollectInput(Farm farm, Sunflower sunflower){
            Console.WriteLine ("1. Natural Field");
            Console.WriteLine ("2. Plowing Field");
            Console.WriteLine ("");
            Console.WriteLine ("Where would you like to Place your Sunflower?");

            Console.WriteLine("> ");

            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {

                case 1:
                    ChooseNaturalField.CollectInput(farm, sunflower);
                    break;
                case 2:
                    ChoosePlowingField.CollectInput(farm, sunflower);
                    break;
                    default:
                    break;



    }
}}}

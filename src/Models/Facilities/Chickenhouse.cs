using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse: IFacility<IGrazing>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }
        // double FeedPerDay { get;}= 0.9;
        public void AddResource (IGrazing animal)
        {
            if(this.Capacity > this._animals.Count){
           _animals.Add(animal);
            }
            else{
                Console.WriteLine("Your chicken has been added to chicken house");
                Console.WriteLine ("Press Enter to return to main menu");
            }
        }

        public void AddResource (List<IGrazing> animals)
        {
animals.ForEach(animals=>_animals.Add(animals));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this._animals.Count} Chickens\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
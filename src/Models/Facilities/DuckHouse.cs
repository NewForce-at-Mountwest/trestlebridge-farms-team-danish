using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IGrazing animal)
        {
             if(this.Capacity > this._animals.Count){
           _animals.Add(animal);
            }
            else{
                Console.WriteLine("Your Duck has been added to Duck house");
                Console.WriteLine ("Press Enter to return to main menu");
            }
        }

        public void AddResource (List<IGrazing> animals)
        {
          animals.ForEach(animals=>_animals.Add(animals));
        }

        internal void AddResource(IDHouse animal)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this._animals.Count} Ducks\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }

    }
}
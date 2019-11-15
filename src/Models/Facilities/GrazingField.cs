using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        // Shows Capacity of facility
        private int _capacity = 50;
        // Assign the grazing Field
        private Guid _id = Guid.NewGuid();
        // List of all Animals that can Graze
        private List<IGrazing> _animals = new List<IGrazing>();
        // Capacity of Facility
        public double Capacity {
            get {
                return _capacity;
            }
        }
        // Add a grazing Animal
        public void AddResource (IGrazing animal)
        {
           _animals.Add(animal);
            // TODO: implement this...

        }
        // Add a grazing Animal to a Grazing Animal List
        public void AddResource (List<IGrazing> animals)
        {
            // TODO: implement this...
            _animals.AddRange(animals);
        }

        // Calculating the Id of the Specific Grazing Field, while also Calculating the amount of Grazing Animals in the Current Grazing Field
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
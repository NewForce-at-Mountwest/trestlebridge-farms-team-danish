using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities{

    public class PlowingField : IFacility<ISeedProducing>
    {
        private int _capacity = 50;

        // public double Harvest();
            public double Capacity  {
            get {
                return _capacity;
            }
            }

        private Guid _id =  Guid.NewGuid();
        private List<ISeedProducing> _seeds = new List<ISeedProducing>();

        public void AddResource(ISeedProducing resource)
        {
              if(this.Capacity > this._seeds.Count)
        {
            _seeds.Add(resource);
        }
        else{
            Console.WriteLine("The seed has been Added to the Plowed Field");
            Console.WriteLine("Press Enter to Return to the Menu");
        }
        }

        public void AddResource(List<ISeedProducing> resources)
        {
             resources.ForEach(resource => _seeds.Add(resource));
           Console.WriteLine("The seeds have been Added to the Plowing Field");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowing field {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
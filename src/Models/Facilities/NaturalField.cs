using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities{

    public class NaturalField : IFacility<ISeedProducing>
    {

        // public double Harvest();
        private int _capacity = 50;
        public double Capacity {
            get {
                return _capacity;
            }
        }

        private Guid _id =  Guid.NewGuid();
        public static List<ISeedProducing> _seeds = new List<ISeedProducing>();

        public void AddResource(ISeedProducing resource){

            if(this.Capacity > _seeds.Count)
        {
            _seeds.Add(resource);
        }
        else{
            Console.WriteLine("The seed has been Added to the Natural Field");
            Console.WriteLine("Press Enter to Return to the Menu");
        }

        }

        public void AddResource(List<ISeedProducing> resources)
        {
           resources.ForEach(resource => _seeds.Add(resource));
           Console.WriteLine("The seeds have been Added to the Natural Field");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {_seeds.Count} seeds\n");
            _seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}
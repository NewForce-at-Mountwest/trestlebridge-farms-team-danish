using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities{

    public class PlowingField : IFacility<ISeedProducing>
    {

        // public double Harvest();
        public double Capacity => throw new NotImplementedException();

        private Guid _id =  Guid.NewGuid();
        private List<ISeedProducing> _seeds = new List<ISeedProducing>();

        public void AddResource(ISeedProducing resource)
        {
            _seeds.Add(resource);
        }

        public void AddResource(List<ISeedProducing> resources)
        {
            _seeds.AddRange(resources);
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
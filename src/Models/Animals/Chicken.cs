using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Chicken : IResource, IGrazing, IMeatProducing {

//chicken id and meat produced
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 1.7;

//give the chicken an id
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

// create chicken and amout of feed per day
        public double GrassPerDay { get; set; } = 2.3;
        public string Type { get; } = "Chicken";

        // Methods
        public void Graze () {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.GrassPerDay}kg of Feed");
        }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Chicken {this._shortId}. Cluck Cluck Cluck!";
        }
    }
}
using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IGrazing, IMeatProducing {

//meat produced
        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 6;

//give the Duck an id
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

// create Duck and amout of feed per day
        public double GrassPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        // Methods
        public void Graze () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.GrassPerDay}kg of Feed");
        }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quack Quack Quack!!!";
        }
    }
}
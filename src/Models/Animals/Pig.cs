using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Pig : IResource, IGrazing, IMeatProducing {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 20;
//add animal id to string with a substring with 6 digits
        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
//set amount of grass and animal type
        public double GrassPerDay { get; set; } = 4;
        public string Type { get; } = "Pig";

        // Methods
        //add line with animal id and grass eaten in a day
        public void Graze () {
            Console.WriteLine($"Pig {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }
// how much meat is produced
        public double Butcher () {
            return _meatProduced;
        }
// animal id in return sentence
        public override string ToString () {
            return $"Pig {this._shortId}. Oink!";
        }
    }
}
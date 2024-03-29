using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<PlowingField> PlowingFields { get; } = new List<PlowingField>();

        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<NaturalField> NaturalFields {get;} = new List<NaturalField>();

        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();
        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "WildFlower":
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Sesame":
                    PlowingFields[index].AddResource((ISeedProducing)resource);
                    break;
                case "Sunflower":
                    PlowingFields[index].AddResource((ISeedProducing)resource);
                    NaturalFields[index].AddResource((ISeedProducing)resource);
                    break;
                    case "Chicken":
                    ChickenHouses[index].AddResource((IGrazing)resource);
                    break;
                      case "Duck":
                    DuckHouses[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;

            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddPlowingField(PlowingField field)
        {
            PlowingFields.Add(field);

        }

        public void AddDuckHouse(DuckHouse DH)
        {
            Console.WriteLine("Adding Duck House...");
            DuckHouses.Add(DH);
        }
        public void AddChickenHouse(ChickenHouse field)
        {
            ChickenHouses.Add(field);
        }

        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(dh => report.Append(dh));
            PlowingFields.ForEach(pf => report.Append(pf));
            NaturalFields.ForEach(nf => report.Append(nf));
            ChickenHouses.ForEach(ch => report.Append(ch));

            return report.ToString();
        }


    }
}
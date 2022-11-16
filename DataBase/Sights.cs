using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Sights
    {
        public string Name = null;
        public string City = null;
        public string Type = null;
        public string Height = null;
        public string Age = null;

        public Sights() { }

        public Sights(string[] data)
        {
            Name = data[0];
            City = data[1];
            Type = data[2];
            Height = data[3];
            Age = data[4];
        }
        public Sights(IStrategy algo)
        {
            Name = String.Empty;
            City = String.Empty;
            Type = String.Empty;
            Height = String.Empty;
            Age = String.Empty;
        }
        public bool Comparing(Sights sight)
        {
            return (this.Name == sight.Name) &&
                (this.City == sight.City) &&
                (this.Type == sight.Type) &&
                (this.Height == sight.Height) &&
                (this.Age == sight.Age);
        }
        public IStrategy Algo { get; set; }
        public List<Sights> Algorithm(Sights parameters, string path)
        {
            return Algo.Algorithm(parameters, path);
        }
    }
}

using FrugtLib.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.Model
{
    public class Frugt : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }

        public Frugt()
        {
            
        }

        public Frugt(int id, string name, int weight, double price)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Weight)}={Weight.ToString()}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}

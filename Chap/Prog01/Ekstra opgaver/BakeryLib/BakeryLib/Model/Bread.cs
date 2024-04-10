using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib.Model
{
    public class Bread : BakeryItem
    {
        private int _weight;
        private bool _fullGrain;



        public int Weight { get => _weight; set => _weight = value; }
        public bool FullGrain { get => _fullGrain; set => _fullGrain = value; }


        public Bread()
        {

        }
        public Bread(string name, int id, double price, bool isCake, int weight, bool fullGrain) : base(name, id, price, isCake)
        {
            _weight = weight;
            _fullGrain = fullGrain;
        }

        public override string ToString()
        {
            return $"{{{nameof(Weight)}={Weight.ToString()}, {nameof(FullGrain)}={FullGrain.ToString()}, {nameof(Name)}={Name}, {nameof(Id)}={Id.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(IsCake)}={IsCake.ToString()}}}";
        }
    }
}

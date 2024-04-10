using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryLib.Model
{
    public class Cake : BakeryItem
    {
        private string _kindOfCake;


        public string KindOfCake
        {
            get { return _kindOfCake; }
            set { _kindOfCake = value; }
        }

        public Cake()
        {

        }
        public Cake(string name, int id, double price, bool isCake, string kindOfCake) : base(name, id, price, isCake)
        {
            _kindOfCake = kindOfCake;
        }

        public override string ToString()
        {
            return $"{{{nameof(KindOfCake)}={KindOfCake}, {nameof(Name)}={Name}, {nameof(Id)}={Id.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(IsCake)}={IsCake.ToString()}}}";
        }
    }
}

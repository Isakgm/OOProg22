using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svømmehold
{
    internal class Aid
    {
        private int _id;
        private string _description;
        private int _amount;

        public Aid():this(-1, "generic", 0)
        {
        }

        public Aid(int id, string description, int amount)
        {
            _id = id;
            _description = description;
            _amount = amount;
        }

        public int Id { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int Amount { get => _amount; set => _amount = value; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Description)}={Description}, {nameof(Amount)}={Amount.ToString()}}}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnect
{
    public class Drink
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Alk { get; set; }

        public Drink(): this(0,"",false)
        {
            
        }

        public Drink(int id, string name, bool alk)
        {
            Id = id;
            Name = name;
            Alk = alk;
        }
    }
}

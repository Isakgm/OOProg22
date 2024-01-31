using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svømmehold
{
    internal abstract class Person
    {
        private int _id;
        private string _name;
        private string _phone;

        public Person():this(-1, "","")
        {
            
        }

        public Person(int id, string name, string phone)
        {
            _id = id;
            _name = name;
            _phone = phone;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Phone)}={Phone}}}";
        }
    }
}

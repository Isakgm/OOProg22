using FrugtLib.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrugtLib.Model
{
    public class Kunde: IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Kunde()
        {

        }

        public Kunde(int id, string name, string phone, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}, {nameof(Phone)}={Phone}, {nameof(Email)}={Email}}}";
        }
    }
}

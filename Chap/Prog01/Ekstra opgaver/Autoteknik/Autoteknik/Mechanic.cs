using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    internal class Mechanic : Person
    {
		private string _education;

        public Mechanic()
        {
            
        }

        public Mechanic(int id, string name, string phone, string education) : base(id, name, phone)
        {
            _education = education;
        }

        public string Education
		{
			get { return _education; }
			set { _education = value; }
		}

        public override string ToString()
        {
            return $"{{{nameof(Education)}={Education}, {nameof(Id)}={Id.ToString()}, {nameof(Phone)}={Phone}, {nameof(Name)}={Name}}}";
        }
    }
}

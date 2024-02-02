using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    internal class Owner : Person
    {
		private string _title;

        public Owner()
        {
            
        }

        public Owner(int id, string name, string phone, string title) : base(id, name, phone)
        {
            _title = title;
        }

        public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

        public override string ToString()
        {
            return $"{{{nameof(Title)}={Title}, {nameof(Id)}={Id.ToString()}, {nameof(Phone)}={Phone}, {nameof(Name)}={Name}}}";
        }
    }
}

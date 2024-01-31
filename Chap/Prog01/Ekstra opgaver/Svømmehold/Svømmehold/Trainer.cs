using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svømmehold
{
    internal class Trainer: Person
    {
		private string _skill;

		public string  Skill
		{
			get { return _skill; }
			set { _skill = value; }
		}

        public Trainer():this (-1,"","","")
        {
            
        }

        public Trainer(int id, string name, string phone, string skill) : base(id, name, phone)
        {
            Skill = skill;
        }

        public override string ToString()
        {
            return $"{{{base.ToString()}{nameof(Skill)}={Skill}}}";
        }
    }
}

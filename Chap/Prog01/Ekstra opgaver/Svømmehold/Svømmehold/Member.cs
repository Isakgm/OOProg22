using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svømmehold
{
    internal class Member: Person
    {
		private int _enrollmentYear;

        //associering
        private List<Team> _teams;

		public int EnrollmentYear
		{
			get { return _enrollmentYear; }
			set { _enrollmentYear = value; }
		}

        public Member() : this(0,"","",0)
        {
            
        }

        public Member(int id, string name, string phone, int year) : base(id, name, phone)
        {
            EnrollmentYear = year;
            _teams = new List<Team>();
        }

        //metode til team membership

        public void AddTeam(Team t)
        {
            _teams.Add(t);
        }

        public void RemoveTeam(int id)
        {
            Team t = _teams.Find( t => t.Id == id);

            if (t != null)
            {
                _teams.Remove(t);
            }
        }

        public override string ToString()
        {
            return $"{{{base.ToString()}, {nameof(EnrollmentYear)}={EnrollmentYear.ToString()}}}";
        }
    }
}

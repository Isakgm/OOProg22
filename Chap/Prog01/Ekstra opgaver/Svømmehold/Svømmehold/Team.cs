using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svømmehold
{
    internal class Team
    {
		private int _id;
		private string _day;
		private int _time;
		private int _limit;

		//associeringer
        //1 træner til Team
		private Trainer _trainer;
        //Flere aid og flere members til Team
		private List<Aid> _aids;
		private List<Member> _members;

		public Trainer Trainer 
		{
			get { return _trainer; } 
			set { _trainer = value; }
		}



		public void AddAid(Aid aid)
		{
			_aids.Add(aid);
		}

        public void RemoveAid(int id)
        {
            Aid a = _aids.Find(a => a.Id == id);

            if (a != null)
            {
                _aids.Remove(a);
            }
        }

		public List<Aid> GetAllAid()
		{
			return new List<Aid>(_aids);
		}

        public int Limit
		{
			get { return _limit; }
			set { _limit = value; }
		}


		public int Time
		{
			get { return _time; }
			set { _time = value; }
		}


		public string Day
		{
			get { return _day; }
			set { _day = value; }
		}


		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

        public Team(int id,int limit, int time, string day)
        {
            Limit = limit;
            Time = time;
            Day = day;
            Id = id;

			_trainer = null;
			_aids = new List<Aid>();
            _members = new List<Member>();
        }

        public Team(int id, int limit, int time, string day, Trainer trainer)
        {
            Limit = limit;
            Time = time;
            Day = day;
            Id = id;

            _trainer = trainer;
			_aids = new List<Aid>();
            _members = new List<Member>();
        }

        public Team():this(-1, 0, 0, "")
        {

        }

		


    public void EnrollMember(Member member)
    {
            //bare ekstra til at man ikke kan tilmelde et member som er null
            if (member == null)
            {
                throw new ArgumentNullException();
            }

            int antal = _members.Count;

            if (antal < Limit)
            {
                _members.Add(member);
                member.AddTeam(this);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Du er for stor til dette hold");
            }

           
    }
    public void RemoveMember(int id)
    {
        Member m = _members.Find(m => m.Id == id);

        if (m != null)
        {
            _members.Remove(m);
            m.RemoveTeam(Id);
        }
    }

    public List<Member> GetAllMembers()
        {
            return new List<Member>(_members);
        }


    public override string ToString()
        {
            string memberStr = "";
            foreach (Member m in _members)
            {
                memberStr = memberStr + ", " + m.ToString();
            }

            string memberStr2 = string.Join(", ", _members);
            return $"{{{nameof(Limit)}={Limit.ToString()}, {nameof(Time)}={Time.ToString()}, {nameof(Day)}={Day}, {nameof(Id)}={Id.ToString()}, Member={memberStr}}}";
        }
    }
}

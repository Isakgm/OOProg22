
using EmployeesV10;
namespace EmployeesV10
{

    public class Teacher : Employee
    {

        private int _payGrade;
        #region Properties
        /*public string Name { get; }
        public int HoursPerWeek { get; set; } */
        public int PayGrade
        {
            get { return _payGrade; }
            set { _payGrade = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"Teacher {Name} works {HoursPerWeek} hours/week, at paygrade {PayGrade}";
            }
        }
        #endregion

        #region Constructor
        public Teacher(string name, int hoursPerWeek, int payGrade) : base(name, hoursPerWeek)

        {
            /* Name = name;
             HoursPerWeek = hoursPerWeek;*/
            PayGrade = payGrade;

        }

        public override string ToString()
        {
            return $"{{{nameof(PayGrade)}={PayGrade.ToString()}, {nameof(AllInformation)}={AllInformation}, {nameof(Name)}={Name}, {nameof(HoursPerWeek)}={HoursPerWeek.ToString()}}}";
        }




        #endregion
    }
}
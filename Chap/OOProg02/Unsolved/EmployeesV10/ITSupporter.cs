
using EmployeesV10;
namespace EmployeesV10
{

    public class ITSupporter : Employee
    {
        private string _primaryWorkArea;
        #region Properties
        /*public string Name { get; }
        public int HoursPerWeek { get; set; }*/
        public string PrimaryWorkArea
        {
            get { return _primaryWorkArea; }
            set { _primaryWorkArea = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"IT-Supporter {Name} works {HoursPerWeek} hours/week, mostly with {PrimaryWorkArea}";
            }
        }
        #endregion

        #region Constructor
        public ITSupporter(string name, int hoursPerWeek, string primaryWorkArea) : base(name, hoursPerWeek)
        {
            /* Name = name;
             HoursPerWeek = hoursPerWeek;*/
            PrimaryWorkArea = primaryWorkArea;
        }

        public override string ToString()
        {
            return $"{{{nameof(PrimaryWorkArea)}={PrimaryWorkArea}, {nameof(AllInformation)}={AllInformation}, {nameof(Name)}={Name}, {nameof(HoursPerWeek)}={HoursPerWeek.ToString()}}}";
        }




        #endregion
    }
}
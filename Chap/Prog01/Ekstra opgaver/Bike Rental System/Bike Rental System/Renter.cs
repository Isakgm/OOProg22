using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Rental_System
{
    internal class Renter
    {
        private string _name;
        private string _address;
        private string _phoneNumber;
        private int _studentId;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; } 
            set {  _address = value; } 
        }

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; } 
        }

        public string PhoneNumber
        { 
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public Renter() 
        { 
            _address = string.Empty;
            _phoneNumber = string.Empty;
            _name = string.Empty;
            _studentId = 0;
        }

        public Renter(string name, string address, string phoneNumber, int studentId)
        {
            _name = name;
            _address = address;
            _phoneNumber = phoneNumber;
            _studentId = studentId;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Address)}={Address}, {nameof(StudentId)}={StudentId.ToString()}, {nameof(PhoneNumber)}={PhoneNumber}}}";
        }
    }
}

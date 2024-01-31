using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseAuto
{
    internal class Car
    {
        private int _year;
        private string _regNo;
        private string _model;
        private string _make;
        private int _id;
        private int _mileage;

        public Car(int year, string regNo, string model, string make, int id, int mileage)
        {
            _year = year;
            _regNo = regNo;
            _model = model;
            _make = make;
            _id = id;
            _mileage = mileage;
        }

        public Car()
        {
            
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }

        public string Model
        { 
            get { return _model; } 
            set {  _model = value; } 
        }
        
        public string Make
        {
            get { return _make; }
            set {  _make = value; } 
        }

        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Year)}={Year.ToString()}, {nameof(RegNo)}={RegNo}, {nameof(Model)}={Model}, {nameof(Make)}={Make}, {nameof(Mileage)}={Mileage.ToString()}}}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    internal class Car
    {
        private int _id;
        private string _regNo;
        private int _year;
        private string _make;
        private string _model;
        private int _mileage;

        private Owner _owner;

        public Owner Owner 
        {
            get { return _owner; } 
            set { _owner = value; }
        }

        Dictionary<int, AutoRepair> _katalog;

        public Dictionary<int, AutoRepair> Katalog
        {
            get { return _katalog; }
            set { _katalog = value; }
        }

       

        public int ID 
        {
            get { return _id; } 
            set { _id = value; }
        }

        public string RegNo
        { 
            get { return _regNo; } 
            set { _regNo = value; } 
        }

        public int Year
        { 
            get { return _year; }
            set {  _year = value; } 
        }

        public string Model
        { 
            get { return _model; }
            set {  _model = value; } 
        }

        public int Mileage
        { 
            get { return _mileage; } 
            set { _mileage = value; }
        }

        public string Make
        {
            get { return _make; } 
            set {  _make = value; }
        }

        public Car() 
        { 
            _katalog = new Dictionary<int, AutoRepair>();
            _id = 0;
            _regNo = string.Empty;
            _year = 0;
            _make = string.Empty;
            _model = string.Empty;
            _mileage = 0;
        }

        public Car(int id, string regNo, int year, string make, string model, int mileage)
        {
            _katalog = new Dictionary<int, AutoRepair>();
            _id = id;
            if (regNo.Length == 7)
            {
                _regNo = regNo;
            }
            else
            {
                throw new ArgumentException("Fejl: Registreringsnummeret skal være 7 tegn");
            }
            _year = year;
            _make = make;
            _model = model;
            _mileage = mileage;
        }

        public void AddAutoRepair(AutoRepair autorepair)
        {
            _katalog.Add(autorepair.Id, autorepair );
        }

        public double TotalAutoRepairCost()
        {
            double total = 0;
            foreach (AutoRepair autorepair in _katalog.Values)
            {
                total = total + autorepair.Price;
            }
            return total;
        }
       
        public override string ToString()
        {
            return $"{{{nameof(Katalog)}={Katalog}, {nameof(ID)}={ID.ToString()}, {nameof(RegNo)}={RegNo}, {nameof(Year)}={Year.ToString()}, {nameof(Model)}={Model}, {nameof(Mileage)}={Mileage.ToString()}, {nameof(Make)}={Make}}}";
        }
    }
}

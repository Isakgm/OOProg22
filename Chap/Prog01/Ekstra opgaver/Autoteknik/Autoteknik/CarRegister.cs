using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    internal class CarRegister
    {
        private List<Car> _liste;

        private string _name;
        private int _cvr;

        public List<Car> Liste
        {
            get { return _liste; }
            set { _liste = value; }
        }

        public CarRegister(string name, int cvr)
        {
            _liste = new List<Car>();
            _name = name;
            _cvr = cvr;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int CVr
        {
            get { return _cvr; }
            set { _cvr = value; }
        }

        public void Add(Car car)
        {
            _liste.Add(car);
        }

        public Car DeleteCar(Car car)
        {
            if(_liste.Contains(car))
            {
                _liste.Remove(car);
                return car;
            }
            return null;
        }

        public List<Car> GetListe()
        {
            return _liste;
        }

        public void AddRepairToCar(string regNo, AutoRepair newAutorepair)
        {
            var foundCar = _liste.FirstOrDefault(c => c.RegNo == regNo);
            
            if (foundCar != null)
            {
                foundCar.AddAutoRepair(newAutorepair);
            }
        }


        
        public override string ToString()
        {
            String _tekst = "";
            foreach (Car c in Liste)
            {
                _tekst += $"{c} \n\t";
            }
            return $"Cars in register: {_tekst}";
        }
    }
}

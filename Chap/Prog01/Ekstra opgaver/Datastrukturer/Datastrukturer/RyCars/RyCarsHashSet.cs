using Datastrukturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrukturer.RyCars
{
    public class RyCarsHashSet: IRyCars

    {
        private HashSet<Car> _cars = new HashSet<Car>();

        public HashSet<Car> Cars
        {
            get { return _cars; }
            set { _cars = value; }
        }

        public void Add(Car car)
        {
            if (_cars.Any(c => c.Id == car.Id))
            {
                throw new ArgumentException("ID is already in use.");
            }
            _cars.Add(car);
        }

        public Car FindCarById(int id)
        {
            Car? c = _cars.FirstOrDefault(c => c.Id == id);

            if (c != null)
            {
                return c;
            }
            else
            {
                // Opdaget en fejl
                throw new KeyNotFoundException($"Car {id} findes ikke");
            }
        }

        public Car FindCarByRegNo(string regNo)
        {
            Car? c = _cars.FirstOrDefault(c => c.RegNo == regNo);

            if (c != null)
            {
                return c;
            }
            else
            {
                // Opdaget en fejl
                throw new KeyNotFoundException($"Car {regNo} findes ikke");
            }
        }

        public Car FindNewestCar()
        {
            return _cars.Last();
        }

        public Car FindOldestCar()
        {
            return _cars.First();
        }

        public ICollection<Car> FindRedCars()
        {
            var redCars = Cars.Where(car => car.Color == "rød").ToList();
            return redCars;
        }

        public ICollection<Car> GetAllCars()
        {
            return _cars;
        }

        public override string ToString()
        {
            String _tekst = "";
            foreach (Car c in Cars)
            {
                _tekst += $"{c} \n\t";
            }
            return $"Biler in register: {_tekst}";
        }
    }
}

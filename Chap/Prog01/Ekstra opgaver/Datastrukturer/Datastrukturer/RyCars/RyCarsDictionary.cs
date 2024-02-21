using Datastrukturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastrukturer.RyCars
{
    public class RyCarsDictionary : IRyCars
    {
       private Dictionary<int, Car> _cars = new Dictionary<int, Car>();

    public void Add(Car car)
    {
        if (_cars.ContainsKey(car.Id))
        {
            throw new ArgumentException("ID is already in use.");
        }
        _cars.Add(car.Id, car);
    }

    public Car FindCarById(int id)
    {
        if (_cars.TryGetValue(id, out Car? car))
        {
            return car;
        }
        else
        {
            throw new KeyNotFoundException($"Car with ID {id} does not exist");
        }
    }

    public Car FindCarByRegNo(string regNo)
    {
        Car? car = _cars.Values.FirstOrDefault(c => c.RegNo == regNo);
        if (car != null)
        {
            return car;
        }
        else
        {
            throw new KeyNotFoundException($"Car with registration number {regNo} does not exist");
        }
    }

    public Car FindNewestCar()
    {
            if (_cars.Count == 0)
            {
                throw new InvalidOperationException("No cars in the registry.");
            }
            int newestId = _cars.Keys.Max();
            return _cars[newestId];
        }

    public Car FindOldestCar()
    {
            if (_cars.Count == 0)
            {
                throw new InvalidOperationException("No cars in the registry.");
            }
            int oldestId = _cars.Keys.Min();
            return _cars[oldestId];
        }

        public ICollection<Car> FindRedCars()
        {
            return _cars.Values.Where(car => car.Color.ToLower() == "red").ToList();
        }

        public ICollection<Car> GetAllCars()
    {
        return _cars.Values;
    }

    public override string ToString()
    {
        string carText = string.Join("\n\t", _cars.Values.Select(c => c.ToString()));
        return $"Cars in registry:\n\t{carText}";
    }
    }
}

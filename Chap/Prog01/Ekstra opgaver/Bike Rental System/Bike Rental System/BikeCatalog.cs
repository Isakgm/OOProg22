using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Rental_System
{
    internal class BikeCatalog
    {

        private List<Bike> _liste;
        private int _numberOfBikes;
        public List<Bike> Liste 
        {
            get {  return _liste; }
            set { _liste = value; }
        }

        public BikeCatalog() 
        {
            _liste = new List<Bike>();
        }

        public void Add(Bike bike) 
        {
            if (BikeExists(bike.ChassisNumber))
            {
                throw new ArgumentException($"Stelnummer {bike.ChassisNumber} fidnes i forvejen");
                
            }
            else
            {
                _liste.Add(bike);
                _numberOfBikes++;
            }
        }

        public bool BikeExists(int chassisNumber)
        {
            return Liste.Any(b => b.ChassisNumber == chassisNumber);
        }
        
        public void PrintBikeList()
        {
            Console.WriteLine(_liste);
            
        }

        public List<Bike> GetAllBikes()
        {
            Console.WriteLine($"Antallet af cykler er{_numberOfBikes++} og tiden lige nu er {DateTime.Now}");
            return _liste;
        }

        public Bike SearchBike(int chassisNumber) 
        {
            Bike resultList = null;

            foreach (Bike b in _liste) 
            {
                if (b.ChassisNumber == chassisNumber)
                {
                    return b;
                }
                
            }
            return resultList;
        }

        public void Remove(int chassisNumber)
        {
            var foundBike = _liste.FirstOrDefault(b => b.ChassisNumber == chassisNumber);
            {
                if(foundBike != null)
                {
                    _liste.Remove(foundBike);
                }
              
            }
            
        }

        public List<Bike> SearchBikesOfModel(string model)
        {
            List<Bike> resultList = new List<Bike>();

            for (int i = 0; i < _liste.Count; i++)
            {
                if (_liste[i].Model == model)
                {
                    resultList.Add(_liste[i]);
                }
            }
            return resultList;

        } 
        
        public void removeAllBikesOfModel(string model)
        {
            List<Bike> resultList = new List<Bike>();

            for (int i = 0; i < _liste.Count; i++)
            {
                if (_liste[i].Model == model)
                {
                    resultList.Remove(_liste[i]);
                }
            }
        }
    }
}

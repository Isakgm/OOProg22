using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    internal class AutoRepair
    {
        private int _id;
        private string _description;
        private double _price;


        public int Id     
        {
            get {  return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        { 
            get { return _price; } 
            set {  _price = value; } 
        }

        public AutoRepair() 
        { 
            _id = 0;
            _description = string.Empty;
            _price = 0;
        }

        public AutoRepair(int id, string description, double price)
        {
            _id = id;
            _description = description;
            _price = price;   
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Description)}={Description}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}

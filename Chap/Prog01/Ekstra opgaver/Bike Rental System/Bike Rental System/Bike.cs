using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Rental_System
{
    internal class Bike
    {
        protected int _yearOfPurchase;
        protected string _model;
        protected string _frameColor;
        protected int _chassisNumber;
        

        public int ChassisNumber
        {
            get { return _chassisNumber; }
               
        }

        public string Model 
        { 
            get { return _model; } 
            set {  _model = value; }
        }

        public string FrameColor
        {
            get { return _frameColor; }
            set { _frameColor = value; }
        }

        public int YearOfPurchase
        {
            get { return _yearOfPurchase;}
            set { _yearOfPurchase = value; }
        }


        public Bike()
        {
            _chassisNumber = 0;
            _frameColor = string.Empty;
            _model = string.Empty;
            _yearOfPurchase = 0;
        }

        public Bike(int chassisNumber, string model, string frameColor, int yearOfPurchase)
        {
            _chassisNumber = chassisNumber;
            _frameColor = frameColor;
            _model = model;
            _yearOfPurchase = yearOfPurchase;
        }

        public override string ToString()
        {
            return $"{{{nameof(ChassisNumber)}={ChassisNumber.ToString()}, {nameof(Model)}={Model}, {nameof(FrameColor)}={FrameColor}, {nameof(YearOfPurchase)}={YearOfPurchase.ToString()}}}";
        }
    }
}

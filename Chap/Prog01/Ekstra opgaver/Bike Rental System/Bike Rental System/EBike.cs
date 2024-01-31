using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Rental_System
{
    internal class EBike : Bike
    {
        private int _engine;


        public int Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }


        public EBike()
        {
            _engine = 0;
        }

        public EBike(int chassisNumber, string model, string frameColor, int yearOfPurchase, int engine)
        {
            _engine = engine;
            _chassisNumber = chassisNumber;
            _model = model;
            _frameColor = frameColor;
            _yearOfPurchase = yearOfPurchase;
        }

        public override string ToString()
        {
            return $"{{{nameof(Engine)}={Engine.ToString()}, {nameof(ChassisNumber)}={ChassisNumber.ToString()}, {nameof(Model)}={Model}, {nameof(FrameColor)}={FrameColor}, {nameof(YearOfPurchase)}={YearOfPurchase.ToString()}}}";
        }
    }
}

namespace Datastrukturer.Model
{
    public class Car
    {
		private int _id;
		private string _color;
		private string _regNo;
		private double _price;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Price
		{
			get { return _price; }
			set { _price = value; }
		}


		public string RegNo
		{
			get { return _regNo; }
			set { _regNo = value; }
		}


		public string Color
		{
			get { return _color; }
			set { _color = value; }
		}
        public Car():this(0,0,"","")
        {
            
        }
        public Car(int id, double price, string regNo, string color)
        {
            Id = id;
            Price = price;
            RegNo = regNo;
            Color = color;
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(RegNo)}={RegNo}, {nameof(Color)}={Color}}}";
        }
    }
}

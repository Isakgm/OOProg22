namespace BakeryLib.Model
{
    public abstract class BakeryItem
    {
        private string _name;
        private int _id;
        private double _price;
        private bool _isCake;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

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

        public bool IsCake
        {
            get { return _isCake; }
            set { _isCake = value; }
        }

        public BakeryItem() : this("", -1, 0, false)
        {

        }

        public BakeryItem(string name, int id, double price, bool isCake)
        {
            Name = name;
            Id = id;
            Price = price;
            IsCake = isCake;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Id)}={Id.ToString()}, {nameof(Price)}={Price.ToString()}, {nameof(IsCake)}={IsCake.ToString()}}}";
        }
    }
}

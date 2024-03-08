namespace ClassLibrary
{
    public class Person
    {
        public string Phone { get; set; }

        public string Name { get; set; }

        public int ShoeSize { get; set; }

        public Person():this ("","",0)
        {
            
        }

        public Person(string phone, string name, int shoeSize)
        {
            Phone = phone;
            Name = name;
            ShoeSize = shoeSize;
        }

        public override string ToString()
        {
            return $"{{{nameof(Phone)}={Phone}, {nameof(Name)}={Name}, {nameof(ShoeSize)}={ShoeSize.ToString()}}}";
        }
    }
}

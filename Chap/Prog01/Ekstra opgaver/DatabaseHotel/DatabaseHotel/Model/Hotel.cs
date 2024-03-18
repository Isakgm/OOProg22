namespace DatabaseHotel.Model
{
    public class Hotel
    {
        public int Hotel_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Hotel(): this (-1, "", "")
        {
            
        }

        public Hotel(int hotel_No, string name, string address)
        {
            Hotel_No = hotel_No;
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"{{{nameof(Hotel_No)}={Hotel_No.ToString()}, {nameof(Name)}={Name}, {nameof(Address)}={Address}}}";
        }
    }
}

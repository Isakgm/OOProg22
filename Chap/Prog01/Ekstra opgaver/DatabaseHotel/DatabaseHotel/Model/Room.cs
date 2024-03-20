namespace DatabaseHotel.Model
{
    public class Room
    {
        public int Room_No { get; set; }
        public int Hotel_No { get; set; }
        public string Types { get; set; }
        public double? Price { get; set; }

        public Room(): this(-1,-1,"",0)
        {
            
        }

        public Room(int room_No, int hotel_No, string types, double? price)
        {
            Room_No = room_No;
            Hotel_No = hotel_No;
            Types = types;
            Price = price;
        }

        public override string ToString()
        {
            return $"{{{nameof(Room_No)}={Room_No.ToString()}, {nameof(Hotel_No)}={Hotel_No.ToString()}, {nameof(Types)}={Types}, {nameof(Price)}={Price.ToString()}}}";
        }
    }
}

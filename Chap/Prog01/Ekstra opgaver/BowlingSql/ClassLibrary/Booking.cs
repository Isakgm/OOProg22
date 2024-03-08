using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Booking
    {

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public string PersonPhone { get; set; }

        public int BowlingAlley { get; set; }

        public Booking():this (0, DateTime.Now, TimeSpan.Zero, "", 0)
        {
            
        }

        public Booking(int id, DateTime date, TimeSpan time, string personPhone, int bowlingAlley)
        {
            Id = id;
            Date = date;
            Time = time;
            PersonPhone = personPhone;
            BowlingAlley = bowlingAlley;
        }
    }
}

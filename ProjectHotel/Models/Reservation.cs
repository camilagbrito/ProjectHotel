using HotelProject.Models.Enums;

namespace HotelProject.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double DailyPrice { get; set; }
        public Status Status { get; set; }

        public Guest Guest { get; set; }

        public Room Room { get; set; }

        public Reservation() { }

        public Reservation(int id, DateTime checkIn, DateTime checkOut, double dailyPrice, Status status, Guest guest, Room room)
        {
            Id = id;
            CheckIn = checkIn;
            CheckOut = checkOut;
            DailyPrice = dailyPrice;
            Status = status;
            Guest = guest;
            Room = room;
        }

        public double TotalPrice(double price, DateTime checkIn, DateTime checkOut) {

            int totalDays = (int) checkIn.Subtract(checkOut).TotalDays;

            return totalDays * price;

        }
    }
}

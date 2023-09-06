using HotelProject.Models.Enums;
using System.ComponentModel;

namespace HotelProject.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public bool Available { get; set; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        public Room() { }

        public Room(int id, string name, string description, Category category, bool available)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            Available = available;
        }

        public void AddReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }

        public void RemoveReservation(Reservation reservation)
        {
            Reservations.Remove(reservation);
        }
    }
}

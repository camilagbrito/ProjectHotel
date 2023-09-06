using System.ComponentModel.DataAnnotations.Schema;

namespace HotelProject.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityCard { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

        public Guest() { }

        public Guest(int id, string name, string identityCard, DateTime birthDate, string phone, string email, Address address)
        {
            Id = id;
            Name = name;
            IdentityCard = identityCard;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Address = address;
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

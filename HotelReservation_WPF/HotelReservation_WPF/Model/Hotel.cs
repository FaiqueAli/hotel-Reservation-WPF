using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_WPF.Model
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }
        public Hotel( string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }
        public IEnumerable<Reservation> GetAllReservationForUser(string username) 
        { 
            return _reservationBook.GetAllReservationForUser(username);
        }
        public void MakeReservation(Reservation reservation) 
        {
            _reservationBook.AddReservation(reservation);
        }

    }
}

using HotelReservation_WPF.Execption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_WPF.Model
{
    public  class ReservationBook
    {
        private readonly List<Reservation> _reservation;
        public ReservationBook()
        {
            _reservation = new List<Reservation>();
        }
        public IEnumerable<Reservation> GetAllReservationForUser(string username)
        {
            return _reservation.Where(x=>x.UserName==username);
        }
        public void AddReservation(Reservation reservation)
        {
            foreach (Reservation existingReservation in _reservation)
            {
                if (existingReservation.conflicts(reservation))
                {
                    throw new ReservationConflictsException(existingReservation,reservation); 
                }
            }
            _reservation.Add(reservation);  
        }
    }
}

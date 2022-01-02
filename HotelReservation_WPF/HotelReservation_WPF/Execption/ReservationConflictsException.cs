using HotelReservation_WPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_WPF.Execption
{
    public class ReservationConflictsException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation InComingReservation { get; }
        public ReservationConflictsException()
        {
        }

        public ReservationConflictsException(string? message) : base(message)
        {
        }

        public ReservationConflictsException(string? message, Exception? innerException, Reservation existingReservation, Reservation inComingReservation) : base(message, innerException)
        {
            ExistingReservation = existingReservation;
            InComingReservation = inComingReservation;
        }

        protected ReservationConflictsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ReservationConflictsException(Reservation existingReservation, Reservation inComingReservation)
        {
            ExistingReservation = existingReservation;
            InComingReservation = inComingReservation;
        }
    }
}

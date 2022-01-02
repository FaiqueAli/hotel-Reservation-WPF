using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_WPF.Model
{
    public class Reservation
    {
        public Reservation(RoomID roomID, DateTime startTime, DateTime endTime,string username)
        {
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
            UserName=username;
        }
        public string UserName{ get;  }
        public RoomID RoomID { get;  }
        public DateTime StartTime { get;  }
        public DateTime EndTime { get;  }
        public TimeSpan length=>EndTime.Subtract(StartTime);

        public bool conflicts(Reservation reservation)
        {
            if(reservation.RoomID!=RoomID)
            { return false; }

            return reservation.StartTime<reservation.EndTime && reservation.EndTime>reservation.StartTime;
        }
    }
}

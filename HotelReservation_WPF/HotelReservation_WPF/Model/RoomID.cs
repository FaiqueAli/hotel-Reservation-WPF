using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_WPF.Model
{
    public class RoomID
    {
        public int RoomNumber { get; }
        public int FloorNumber { get; }

        public RoomID(int floorNumber,int roomnumber) 
        {
            RoomNumber = roomnumber;
            FloorNumber = floorNumber;
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomid &&
                FloorNumber == roomid.FloorNumber &&
                RoomNumber == roomid.RoomNumber;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine( FloorNumber, RoomNumber);
        }
        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }
        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 is null && roomID2 is null) {
                return true;
            }
            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }
        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }
    }
}

using HotelReservation_WPF.Execption;
using HotelReservation_WPF.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelReservation_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Demo Hotel");
            try {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 3), new DateTime(2022, 1, 1), new DateTime(2022, 1, 3), "Faiq"));
                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 5), new DateTime(2022, 1, 4), new DateTime(2022, 1, 6), "Faiq"));
            }
            catch (ReservationConflictsException ex)
            {
                
            }
            

            IEnumerable<Reservation> _userReservation = hotel.GetAllReservationForUser("Faiq");
            base.OnStartup(e);
        }
    }
}

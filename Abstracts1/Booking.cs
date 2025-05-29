using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracts1.ACs;

namespace Abstracts1
{


    internal class Booking
    {
        List<ACReservation> reservations = new List<ACReservation>(); 

        public Booking() { }
        
        public void CreateReservation(ACReservation reservation)
        {
            reservations.Add(reservation);
        }

        public void CancelReservation(int id)
        {
            foreach (ACReservation reservation in reservations)
            {
                if (reservation.ReservationID == id)
                {
                    reservations.Remove(reservation);
                }
            }
        }

        public int GetMoney()
        {
            int money = 0;

            foreach (ACReservation reservation in reservations)
            {
                money += reservation.CalculatePrice();
            }
            return money;
        }

    }
}

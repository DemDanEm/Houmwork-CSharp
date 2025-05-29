using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracts1.ACs;

namespace Abstracts1.Reservations
{
    internal class FlightReservation : ACReservation
    {
        string DepartureAirport;
        string ArrivalAirport;

        public override int CalculatePrice()
        {
            return 1000 * (base.EndDate - base.StartDate) + (DepartureAirport.Length + ArrivalAirport.Length)* 200;
        }

        public FlightReservation(string departure, string arrival, int id, string name, int start, int end) : base(id, name, start, end)
        {
            DepartureAirport = departure;
            ArrivalAirport = arrival;
        }
    }
}

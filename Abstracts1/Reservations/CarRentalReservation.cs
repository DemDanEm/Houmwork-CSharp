using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracts1.ACs;

namespace Abstracts1.Reservations
{
    internal class CarRentalReservation : ACReservation
    {
        int CarType;
        int InsuranceOption;

        public override int CalculatePrice()
        {
            return 1000 * (base.EndDate - base.StartDate) + CarType* 1550 * InsuranceOption * 800;
        }

        public CarRentalReservation(int type, int insurance, int id, string name, int start, int end) : base(id, name, start, end)
        {
            CarType = type;
            InsuranceOption = insurance;
        }
    }
}

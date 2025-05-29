using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracts1.ACs;

namespace Abstracts1.Reservations
{
    internal class HotelReservation: ACReservation
    {
        int RoomType;
        string MealPlan;

        public override int CalculatePrice()
        {
            return 1000 * (base.EndDate - base.StartDate) + (RoomType * 750) + (MealPlan.Length * 50);
        }

        public HotelReservation(int roomType, string mealPlan, int id, string name, int start, int end) : base(id, name, start, end)
        {
            RoomType = roomType;
            MealPlan = mealPlan;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts1.ACs
{
    internal abstract class ACReservation
    {
        public int ReservationID { get; }
        protected string CustomerName;
        protected int StartDate;
        protected int EndDate;

        public abstract int CalculatePrice();

        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID: " +
                ReservationID.ToString() +
                "\nCustomer Name: " +
                CustomerName.ToString() +
                "\nStart Date: " +
                StartDate.ToString() +
                "\nEnd Date: " +
                EndDate.ToString()
                );
        }

        protected ACReservation(int id, string name, int start, int end) 
        { 
            this.ReservationID = id;
            this.CustomerName = name;
            this.StartDate = start;
            this.EndDate = end;
        }
    }
}

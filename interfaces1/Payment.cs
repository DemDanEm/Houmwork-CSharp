using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces1
{
    internal struct Payment
    {
        public int value {  get; set; }

        public string sender { get; set; }
        public string reciever { get; set; }

        public string status = "PENDING";


        public void valid()
        {
            status = "VALID";
        }

        public void pending()
        {
            status = "PENDING";
        }

        public void complete()
        {
            status = "COMPLETE";
        }

        public void refund()
        {
            status = "REFUNDED";
        }

        public Payment(int val, string send, string recieve)
        {
            value = val;
            sender = send;
            reciever = recieve;
        }

        public Payment() { }
    }
}

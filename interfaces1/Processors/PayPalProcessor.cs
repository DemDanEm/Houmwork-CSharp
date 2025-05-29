using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static interfaces1.Interfaces.IPaymentProcessor;

using interfaces1.Interfaces;

namespace interfaces1.Processors
{
    internal class PayPalProcessor: AbstractProcessor, IPaymentProcessor
    {
        void IPaymentProcessor.ProcessPayment()
        {
            if (payment.status == "VALID")
            {
                payment.complete();
            }
        }

        void IPaymentProcessor.RefundPayment()
        {
            payment.refund();
        }

        public PayPalProcessor(Payment pay) : base(pay) { }

    }
}

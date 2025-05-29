using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static interfaces1.Interfaces.IPaymentProcessor;

using interfaces1.Interfaces;
using interfaces1.Processors;


namespace interfaces1
{
    internal class CryptoCurrencyProcessor: AbstractProcessor, IPaymentProcessor
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

        public CryptoCurrencyProcessor(Payment pay) : base(pay) { }
    }
}

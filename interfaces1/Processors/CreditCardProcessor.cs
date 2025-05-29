using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static interfaces1.Interfaces.IPaymentProcessor;
using static interfaces1.Interfaces.IPaymentValidator;

using static interfaces1.Processors.AbstractProcessor;

using static interfaces1.Payment;

using interfaces1.Interfaces;
using interfaces1.Processors;


namespace interfaces1
{
    internal class CreditCardProcessor: AbstractProcessor, IPaymentProcessor, IPaymentValidator
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

        void IPaymentValidator.ValidatePayment()
        {
            if (payment.sender != null || payment.reciever != null || payment.sender != payment.reciever)
            {
                payment.complete();
            }
        }

        public CreditCardProcessor(Payment payment) : base(payment) { }
    }
}

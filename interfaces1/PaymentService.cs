using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static interfaces1.Interfaces.IPaymentProcessor;
using static interfaces1.Interfaces.IPaymentValidator;

using interfaces1.Interfaces;



namespace interfaces1
{
    internal class PaymentService
    {
        public PaymentService(IPaymentProcessor processor, IPaymentValidator validator) 
        { 
            

        }


    }
}

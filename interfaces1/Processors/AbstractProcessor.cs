using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static interfaces1.Payment;

namespace interfaces1.Processors
{
    internal abstract class AbstractProcessor
    {
        protected interfaces1.Payment payment { get; set; }
        protected AbstractProcessor(interfaces1.Payment pay) 
        { 
            payment = pay;
        }
    }
}

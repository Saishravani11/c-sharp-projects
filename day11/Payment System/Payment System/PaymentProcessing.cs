using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    internal class PaymentProcessing
    {


        // universal adapter // Interface
        private readonly IPayment _payment;


        //Injecting dependency via constructor or we can also inject through get / set
        // High level module is dependent on low level modules but via abstraction
        public PaymentProcessing(IPayment pm)
        {
            _payment = pm;

        }
        public void ExecutePayment(decimal amount)
        {
            _payment.ProcessPayment(amount);

        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    class Programm
    {

        static void Main()
        {
            // OPEN / Closed Principal
            //to get the payment using credit card I need to achieve it with abstraction
            IPayment pm = new CreditCaard(); // we can switch the payment methods here
            PaymentProcessing processing = new PaymentProcessing(pm); //High level class
            processing.ExecutePayment(1000);


            // loosely coupled :  paymentprocessor class directly  depends on Ipayment method rather than a specific class
            // If we need to add another payment method we need to  modify paymentprocessing ( Easy extension of classes
            //Supports DI  : We can inject any payment method dynamically at runtime and also can test the modules
            // both high level should not depend on low level . Both should depend on abstraction(Interface)
        }
    }
}

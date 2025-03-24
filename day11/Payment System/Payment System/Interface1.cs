using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);
    }


    public class CreditCaard : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Paytm : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }


}

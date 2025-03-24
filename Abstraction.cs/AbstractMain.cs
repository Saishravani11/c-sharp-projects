using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class AbstractMain
    {
        public static void  Main(string[] args)
        {
            Console.WriteLine("Enter the bank Name");
            string bn=Console.ReadLine();
            AbstractionDemo bnb = BankNames.GetBankName(bn);
            bnb.BankTransfer();
            bnb.Withdraw();
        }
    }
}

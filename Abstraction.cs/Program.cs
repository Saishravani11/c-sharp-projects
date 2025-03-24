using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class AbstractionDemo
    {
        public abstract void BankTransfer();
        public abstract void Withdraw();

        public abstract void Deposit();
        public abstract void MiniStatement();
        public void BankHolidays()
        {
            Console.WriteLine("offdays");
        }

    }
    public class SBI : AbstractionDemo
    {
        public override void BankTransfer()
        {
            Console.WriteLine("AMOUNT Transfered");
        }
        public override void Withdraw()
        {
            Console.WriteLine("Amount Withdrawn");
        }
        
        public override void Deposit()
        {
            Console.WriteLine("Amount Deposit");
            throw new NotImplementedException();
        }
        public override void MiniStatement()
        {
            throw new NotImplementedException();
        }


    }
    public class Axis : AbstractionDemo
    {
        public override void BankTransfer()
        {
            Console.WriteLine("Amount Transfered");
        }
        public override void Withdraw()
        {
            Console.WriteLine("Amount withdrawn");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("Bank Amount Statements ");
        }
        public override void Deposit()
        {
            Console.WriteLine("Bank Amount Deposit");
        }

    }
    public class BankNames
    {
        public static AbstractionDemo GetBankName(string bankName)
        {
            AbstractionDemo bankobj = null;
            if (bankName == "SBI")
            {
                bankobj = new SBI();
            }
            else if (bankName == "Axis")
            {
                bankobj = new Axis();    
            }
            return bankobj;
        }
    }
}

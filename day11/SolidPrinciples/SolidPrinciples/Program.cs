using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public abstract class BankAccount
    {

        protected double balance;

        public virtual void Deposit(double amount)
        {

            balance += amount;

            Console.WriteLine("Deposited Amount: {amount}, Total Amount Now: { balance}");
        }

        public abstract void Withdraw(double amount);
        public double GetBalance() { return balance; }



    }

    public class SavingAccount : BankAccount
    {

        public override void Withdraw(double amount)
        {
            // base.withdraw(amount);
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdraw : {amount}, Balance : {balance}");
            }
            else
            {
                throw new InvalidOperationException("Insufficient amount");

            }


        }
    }

    public class FixedDeposit : BankAccount
    {
        bool termEnded = false;
        public override void Withdraw(double amount)
        {
            // base.withdraw(amount);

            if (!termEnded)
            {
                Console.WriteLine("cannot withdraw from a fixed deposit account");


            }
            else if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdraw : {amount}, Balance : {balance}");

            }


        }

    }



    public class Program()
    {
        public static void Main()
        {
            var SavingAccount = new SavingAccount();
            SavingAccount.Deposit(4000);
            SavingAccount.Deposit(6000);
            SavingAccount.Deposit(1000);
            SavingAccount.Withdraw(500);

            var FixedDeposit = new FixedDeposit();
            FixedDeposit.Deposit(1000);
            FixedDeposit.Withdraw(500);

        }


    }
}

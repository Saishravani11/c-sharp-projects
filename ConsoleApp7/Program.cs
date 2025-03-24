using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        protected string AccountNumber { get; set; }
        private double Balance { get; set; }
        internal string BankName { get; set; }

        public BankAccount(string accountHolder, string accountNumber, double balance, string bankName)
        {
            AccountHolder= accountHolder;
            AccountNumber= accountNumber;
            Balance= balance;
            BankName= bankName;
        }
        public void showAccountDetails()
        {
            Console.WriteLine(AccountHolder);
            Console.WriteLine(BankName);

        }
        



    }
    class SavingAccount : BankAccount
    {
        SavingAccount(string accountHolder, string accountNumber, double balance):base(accountHolder,accountNumber,balance)
        {
            AccountHolder= accountHolder;
            BankName= accountNumber;    
            Balance=balance;
           

        }
        public void showAccountNumber(acc_no)
        {
            Console.WriteLine(acc_no)
        }
    }
    public static void Main(string[] args)
        {
            Console.WriteLine(AccountHolder)
        }

}


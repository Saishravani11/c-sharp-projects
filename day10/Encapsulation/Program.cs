using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Bank
    { //public int property1{get;set;}
        private double balance;
        //public double Balance{  -- this is  a property created for get and set
        //get{return balance;}-- getter to retrieve the balance
        //set
        //*
        //{

        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double balanceamount)
        {
            if (balanceamount > 0) //if you use variable :"value" intead of balanceamout;
            {

                this.balance = balanceamount;
            }
            else
            {
                Console.WriteLine("please enter only positive values");
            }
            //}
            //}
        }
        class Program
        {


            static void Main(string[] args)
            {
                //Console.WriteLine("enter a amount to save");
                //double value= Convert.ToInt32(Console.ReadLine());
                //bank.Balance=value;
                Bank bank = new Bank();
                
                bank.SetBalance(500);
                Console.WriteLine(bank.GetBalance());

            }
        }
    }
}

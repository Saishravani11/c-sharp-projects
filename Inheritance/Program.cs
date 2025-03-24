using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inheritance1
{
    internal class Inheritance
    {
        public Inheritance() 
        {
            Console.WriteLine("Base class constructor called");
        }
        private void License()
        {

        }
        public void Method1()
        {
            Console.WriteLine("Method 1 called:");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2 called:");
        }
    }
    class ConsumedClass : Inheritance
    {
        public ConsumedClass()
            {
            Console.WriteLine("Child class constroctor");
            }



        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
        public static void Main(string[] args)
        {
            ConsumedClass c = new ConsumedClass();
            c.Method1();
            c.Method2();
            c.Method3();
            //we have not created  any object of parent class it is unassigned gives error
            //Inheritance pobj;
            //pobj.Method2();
            //we can intialize parent class variable with the help of child class instance
            // pobj = c;//here pobjis reference of Parent class created by using child class i
            Inheritance pobj1 = new ConsumedClass();
            pobj1.Method2();
            // we cannot call any pure child    class members using the refernce variable of parent
           // pobj1.Method3(); error
            ConsumedClass cobj2 = (ConsumedClass)new Inheritance();
            


        }

    }

}

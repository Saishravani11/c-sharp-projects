using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{ 
     class VotingException : Exception
{
    int age;
    public override string Message
    {
        get
        {
            return "you are not eligible to vote";
        }

    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            /* try
             {
                 Console.WriteLine("Enter 1st number");
                 int a = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter 2nd number");
                 int b = Convert.ToInt32(Console.ReadLine());
                 int result = a / b;

                 Console.WriteLine(result);
             }
             catch (FormatException ex1)
             {
                 Console.WriteLine("Enter only Integer"+ex1.Message);
             }
             catch (Exception ex) {
                 Console.WriteLine("Exception has occured"+ex.Message);
                 Console.WriteLine("Exceptin has occured"+ex.StackTrace);*/
            try
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age < 18)
                {
                    throw new VotingException();
                }
                else
                {
                    Console.WriteLine("voted sucessfully");
                }
            }
            catch(VotingException v){
                Console.WriteLine("message is" + v.Message);
                    
            }


            
            }

            
          
         
        

    }
    
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Trigger DivideByZeroException
                int x = 5;
                int y = 0;
                Console.WriteLine(x / y);  // This will throw DivideByZeroException
               
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division by zero error: " + ex.Message);
            }

        }
    }
}

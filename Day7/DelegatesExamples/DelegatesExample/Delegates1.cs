using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class Delegates1
    {
        public delegate void PrintDelegate();
        static void Main(string[] args)
        {
            PrintDelegate pd = new PrintDelegate(printData);
            pd();

        }
        public static void printData()
        {
            Console.WriteLine("Delegate associated with method has been called");
        }

    }
}

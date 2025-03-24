using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of a rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth of a rectangle:");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int Area = length * breadth;
            Console.WriteLine("Area:" + Area);

        
                }

    }
}

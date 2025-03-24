using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e = new Employee(101, "Niti", "Trainer");

            /*Console.WriteLine(e[2]);
            //To set the value 
            e[2] = "Preeti";

            Console.WriteLine("After resetting the value ; ");
            Console.WriteLine(e[2]);*/

            e["Name"] = "Kriti";
            e["job"] = "Corporate Trainer";

            Console.WriteLine("After resetting the value ; ");
            Console.WriteLine(e["Name"]);
            Console.WriteLine(e["job"]);

        }
    }
}

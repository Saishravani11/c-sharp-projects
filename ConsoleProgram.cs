using System;
using System.IO.Compression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
    namespace ConsoleProgram
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello");
                Console.Write("Hii");
                Console.Write("All");
                string name="Csharp";
                Console.WriteLine(name);
                // string interpolation
                Console.WriteLine($"Learning:{name}");
                Console.WriteLine("Enter a Key:");
                int var1=Console.Read();
                Console.WriteLine($"Ascii value of key you have entered : {var1}");
                Console.WriteLine("Enter another Key:");
                ConsoleKeyInfo var2=Console.ReadKey();

                Console.WriteLine($"You have entered:{var2.Key}");


            }
        }
        
    }

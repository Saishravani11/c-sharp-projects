using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethods

{
    public sealed class Service
    {
        public int x = 100;
        public void Test1()
        {
            System.Console.WriteLine("This is test1 method");

        }
        public void Test2()
        {
            System.Console.WriteLine("This id test2 method");
        }
    }
        public static class NewService
        {
            public static void Test3(this Service ser)// Method will become non static for old service class
             {

              }
        public static void Test4(this Service ser, int x)
        {
            Console.WriteLine(x);
            Console.WriteLine(ser.x);
        }
        
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            Service s=new Service();
            s.Test1();
            s.Test2();
            s.Test3();
            s.Test4(100);
        }
    }
}

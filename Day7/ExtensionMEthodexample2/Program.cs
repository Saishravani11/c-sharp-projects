using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExtensionMEthodexample2
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* OldService service1 = new OldService();
             service1.Test1();
             service1.Test2();
             service1.Test3();
             service1.Test4(50);*/


            string word = "C# is a powerful language";

            int wordcount = word.GetWordCounted();
            Console.WriteLine("Total words in a given string :" + wordcount);

        }

    }
}

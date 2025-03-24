using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDesignPattern
{
    public class Mobile
    {
        public string storage { get; set; }
        public string os { get; set; }

        public void showSpecification()
        {
            Console.WriteLine($"storage:{storage}");

        }
    }
}

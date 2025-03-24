using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullsafety
{
    enum weekDays{
        Monday, Tuesday, Wednesday,Thursday, Friday,Saturday, Sunday  
    }
    internal class Program
    {
        static string GetYourDay(weekDays day)=>day switch
        {
            weekDays.Monday => "GoodLuck",
            weekDays .Tuesday =>"GoodLuck",
            weekDays.Wednesday =>"",
            weekDays.Thursday =>"",
            weekDays.Friday =>"",
            weekDays.Saturday =>"",
            weekDays.Sunday =>""
        };
        static void Main(string[] args)
        {
            weekDays weekDays = new weekDays();
            Console.WriteLine(GetYourDay(weekDays));
        }
    }
}

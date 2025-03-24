using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            CEmployee employee = new CEmployee();
            employee.setPanDetails("ABCDE1234F");
            Console.WriteLine($"Employee PAN: {employee.getPanDetails()}");
            employee.Lastdrawn();

            PEmp pEmp = new PEmp();
            pEmp.setPanDetails("XYZAB6789G");
            Console.WriteLine($"PEmp PAN: {pEmp.getPanDetails()}");
            pEmp.Lastdrawn();
        }
    }
}


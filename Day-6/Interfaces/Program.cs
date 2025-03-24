using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
      interface ISalaryDetails
    {
         void Lastdrawn();
    }
    public abstract class PersonalDetails
    {
        public abstract string getPanDetails();
        public abstract string setPanDetails(string pan);
        private double BasicPay()
        {
            return 350000;
        }

    }
    public class CEmployee : PersonalDetails, ISalaryDetails
    {
        public string pan;
        private double BasicPay()
        {
            return 350000;
        }

        public override string getPanDetails()
        {
            return pan;
        }

        
        public override string setPanDetails(string pan)
        {
            pan = pan;
            return pan;
        }

        public void Lastdrawn()
        {
            Console.WriteLine("Last Drawn salary is 50000");
        }
    }
    public class PEmp : PersonalDetails, ISalaryDetails

    {
        string pan;
        public override string getPanDetails()
        {
            return pan;
        }

        public void Lastdrawn()
        {
            Console.WriteLine("Last Drawn salary is 10000");
        }

        public override string setPanDetails(string pan)
        {
            pan = pan;
            return pan;
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment
{
    internal class LSP
    {
        // Financial report class - Inherits from Report
        public class FinancialReport : Report
        {
            public override void GenerateContent()
            {
                Content = "This is the financial report content.";
            }
        }

        // Sales report class - Inherits from Report
        public class SalesReport : Report
        {
            public override void GenerateContent()
            {
                Content = "This is the sales report content.";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment
{
    
    public abstract class Report
    {
        public string ReportType { get; set; }
        public string Content { get; set; }

        // Abstract method for generating the content
        public abstract void GenerateContent();
    }
    // Financial report class - Inherits from Report
    public class FinancialReport : Report
    {
        public override void GenerateContent()
        {
            // Generate financial report content
            Content = "This is the financial report content.";
        }
    }

    // Sales report class - Inherits from Report
    public class SalesReport : Report
    {
        public override void GenerateContent()
        {
            // Generate sales report content
            Content = "This is the sales report content.";
        }
    }



}

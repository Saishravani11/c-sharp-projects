using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment
{
    // Interface for generating reports
    public interface IReportGenerator
    {
        Report Generate(string reportType);
    }

    // Interface for saving reports
    public interface IReportSaver
    {
        void Save(Report report, string filePath);
    }

    // Interface for formatting reports
    
    // Report generator - Implements IReportGenerator
    public class ReportGenerator : IReportGenerator
    {
        public Report Generate(string reportType)
        {
            if (reportType == "Financial")
            {
                return new FinancialReport();
            }
            else if (reportType == "Sales")
            {
                return new SalesReport();
            }
            else
            {
                throw new ArgumentException("Unknown report type");
            }
        }
        // Report saver - Implements IReportSaver
        public class ReportSaver : IReportSaver
        {
            public void Save(Report report, string filePath)
            {
                // Save the report content to a file
                System.IO.File.WriteAllText(filePath, report.Content);
            }
        }

    }


}

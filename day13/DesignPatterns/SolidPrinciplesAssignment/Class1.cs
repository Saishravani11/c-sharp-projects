using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment
{
    using System;
    using static DesignPatternAssignment.ReportGenerator;

    public class Program
    {
        public static void Main(string[] arg)
        {
            // Instantiate the necessary components
            IReportGenerator reportGenerator = new ReportGenerator();
            IReportSaver reportSaver = new ReportSaver();
            IReportFormatter reportFormatter = new PDFReportFormatter(); // You can change to ExcelReportFormatter

            // Create the ReportService with dependencies injected
            var reportService = new ReportService(reportGenerator, reportSaver, reportFormatter);

            // Generate and save a report
            reportService.GenerateAndSaveReport("Financial", "financial_report.pdf");
            reportService.GenerateAndSaveReport("Sales", "sales_report.xlsx");

            Console.WriteLine("Reports have been generated and saved successfully.");
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment
{
    // Report service - Manages the report generation, formatting, and saving
    public class ReportService
    {
        private readonly IReportGenerator _reportGenerator;
        private readonly IReportSaver _reportSaver;
        private readonly IReportFormatter _reportFormatter;

        // Constructor Injection for Dependency Inversion
        public ReportService(IReportGenerator reportGenerator, IReportSaver reportSaver, IReportFormatter reportFormatter)
        {
            _reportGenerator = reportGenerator;
            _reportSaver = reportSaver;
            _reportFormatter = reportFormatter;
        }

        // Method to generate, format, and save the report
        public void GenerateAndSaveReport(string reportType, string filePath)
        {
            // Step 1: Generate the report
            var report = _reportGenerator.Generate(reportType);

            // Step 2: Generate the content for the report
            report.GenerateContent();

            // Step 3: Format the report
            var formattedReport = _reportFormatter.Format(report);

            // Step 4: Save the formatted report
            report.Content = formattedReport;
            _reportSaver.Save(report, filePath);
        }
    }

}

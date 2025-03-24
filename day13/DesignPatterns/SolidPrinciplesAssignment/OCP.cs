using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment
{
    public interface IReportFormatter
    {
        string Format(Report report);
    }
    // Report formatter for PDF - Implements IReportFormatter
    public class PDFReportFormatter : IReportFormatter
    {
        public string Format(Report report)
        {
            return $"[PDF Format] {report.Content}";
        }
    }

    // Report formatter for Excel - Implements IReportFormatter
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(Report report)
        {
            return $"[Excel Format] {report.Content}";
        }
    }


}

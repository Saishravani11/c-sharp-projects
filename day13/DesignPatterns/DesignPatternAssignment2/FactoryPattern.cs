using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment2
{
    

    public abstract class Document
    {
        public abstract void Print();
    }

    public class PDFDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing PDF document...");
        }
    }

    public class WordDocument : Document
    {
        public override void Print()
        {
            Console.WriteLine("Printing Word document...");
        }
    }

    public class DocumentFactory
    {
        public static Document CreateDocument(string type)
        {
            if (type == "PDF")
            {
                return new PDFDocument();
            }
            else if (type == "Word")
            {
                return new WordDocument();
            }
            else
            {
                throw new ArgumentException("Invalid document type.");
            }
        }
    }
    public class Program
    {
        public static void Main2(string[] args)
        {
            // Using the Factory to create documents
            Document pdfDoc = DocumentFactory.CreateDocument("PDF");
            pdfDoc.Print();  // Output: Printing PDF document...

            Document wordDoc = DocumentFactory.CreateDocument("Word");
            wordDoc.Print();  // Output: Printing Word document...
        }
    }


}

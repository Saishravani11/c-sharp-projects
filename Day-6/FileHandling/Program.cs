using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logDirectory="logs";
            string logFilePath = @"C:\Users\saish\OneDrive\Documents\training\test1\day5\logs";
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logFilePath);
                Console.WriteLine("Log Directory created");
            }
            Console.WriteLine("Collect user Details:");
            Console.WriteLine("Enter your Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Adress");
            string email=Console.ReadLine();
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logentry = $"{timestamp}-Name:{name},Age:{age},Email:{email}";
            File.AppendAllText(logFilePath, logentry );
            Console.WriteLine("User details saved to log file.");
            Console.WriteLine("\nReading user details from log file...");
            if (File.Exists(logFilePath))
            {
                string[] logEntries = File.ReadAllLines(logFilePath);
                foreach (var entry in logEntries)
                {
                    Console.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("Log file not found.");
            }


        }
    }
}

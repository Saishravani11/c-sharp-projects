using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment2
{
    

    public class Logger
    {
        private static Logger _instance;
        private static readonly object _lock = new object();

        // Private constructor to prevent instantiation
        private Logger() { }

        // Public method to access the Singleton instance
        public static Logger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        // Method to log messages
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                // Using the Singleton Logger
                Logger logger1 = Logger.Instance;
                logger1.Log("This is the first log message.");

                Logger logger2 = Logger.Instance;
                logger2.Log("This is the second log message.");

                // Verifying that both logger1 and logger2 point to the same instance
                Console.WriteLine(ReferenceEquals(logger1, logger2)); // Output: True
            }
        }

    }


}

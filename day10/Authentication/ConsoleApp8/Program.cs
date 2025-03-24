using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    using NLog; // add this library

    public class AuthenticationService
    {

        //It's an instance of Logger class
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private Dictionary<string, string> _users = new Dictionary<string, string>()
    {
        { "niti" , "password123"},
        { "john","password12345"}



    };

        public bool Login(string username, string password)
        {

            logger.Info($"Login attempt has made : {username}");

            if (!_users.ContainsKey(username))
            {
                logger.Warn($"Login failed : Incorrect password for the user : {username}");
                Console.WriteLine("Invalid User Name and password");
                return false;

            }

            logger.Info($"Login successful for username: {username}");
            Console.WriteLine("Login successful :");
            return true;

        }





    }

    class Program
    {
        // Removed unused 'args' parameter from Main method
        static void Main()
        {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile1") { FileName = "logfile1.txt" };

            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole); // create a log rule what we want store or display on console
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            LogManager.Configuration = config; //  use to apply all the configuration you have set


            AuthenticationService authenticationService = new AuthenticationService();



            authenticationService.Login("niti", "password123"); // 
            authenticationService.Login("nitinn", "password"); // should fail to login
            var auth = new UserAuthentication(); // created an instance of authentication
            var encryption = new DataEncryption(); // created an instance of encryption
            bool ex = true;

            while (ex)
            {
                Console.WriteLine("Welcome to the Secure Application!");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter username: ");
                        string registerUsername = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string registerPassword = Console.ReadLine();

                        Console.Write("Enter sensitive data to encrypt: ");
                        string sensitiveData = Console.ReadLine();

                        // Register user
                        auth.Register(registerUsername, registerPassword);

                        // Encrypt sensitive data
                        string encryptedData = encryption.Encrypt(sensitiveData);
                        Console.WriteLine("User registered successfully!");
                        Console.WriteLine($"Encrypted Sensitive Data: {encryptedData}");

                        // Store encrypted data for later use
                        Console.WriteLine("Remember your encrypted data: " + encryptedData);
                        break;

                    case "2":
                        Console.Write("Enter username: ");
                        string loginUsername = Console.ReadLine();

                        Console.Write("Enter password: ");
                        string loginPassword = Console.ReadLine();

                        // Authenticate user
                        if (auth.Authenticate(loginUsername, loginPassword))
                        {
                            Console.Write("Enter encrypted data to decrypt: ");
                            string encryptedDataToDecrypt = Console.ReadLine();

                            // Decrypt sensitive data
                            try
                            {
                                string decryptedData = encryption.Decrypt(encryptedDataToDecrypt);
                                Console.WriteLine($"Decrypted Sensitive Data: {decryptedData}");
                            }
                            catch
                            {
                                Console.WriteLine("Invalid encrypted data.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid username or password.");
                        }
                        break;

                    case "3":
                        ex = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Exiting...");
                        break;
                }
            }
        }
    }
}



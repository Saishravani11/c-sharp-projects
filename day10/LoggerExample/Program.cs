using System.Collections.Generic;
using System;
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
    static void Main()
    {
        // Configure NLog

        var config = new NLog.Config.LoggingConfiguration();

        var logfile = new NLog.Targets.FileTarget("logfile1") { FileName = "logfile1.txt" };

        var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logconsole); // create a log rule what we want store or display on console
        config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

        LogManager.Configuration = config; //  use to apply all the configuration you have set


        AuthenticationService authenticationService = new AuthenticationService();



        authenticationService.Login("niti", "password123"); // 
        authenticationService.Login("nitinn", "password"); // should fail to login


    }



}

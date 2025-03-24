using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LoginTestCase;
namespace LoginTestCase
{
    [TestClass]
    public sealed class Test1
    {
        Login login = new Login();
        string loginresult;
        [TestMethod]
        public void Check_username_null()
        {

            Login.DoLogin(null, "admin", out loginresult);
            Console.WriteLine(loginresult);

        }
        [TestMethod]
        public void Check_password_null()
        {
            Login.DoLogin("admin", null, out loginresult);
            Console.WriteLine(loginresult);
        }
        [TestMethod]
        public void Check()
        {
            Login.DoLogin("admin", "admin", out loginresult);
            Console.WriteLine(loginresult);
        }

        [TestMethod]
        public void Check_both_null()
        {
            Login.DoLogin(null, null, out loginresult);
            Console.WriteLine(loginresult);
        }
        //Incorrect username and password   
        [TestMethod]
        public void Check_both()
        {
            Login.DoLogin("asddas", "sad", out loginresult);
            Console.WriteLine(loginresult);
        }
    }
}

        
        
        
        
    
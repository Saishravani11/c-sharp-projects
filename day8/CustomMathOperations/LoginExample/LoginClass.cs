
namespace LoginTestCase
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public static string check { get; set; }

        public static void DoLogin(string username, string password, out string result)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "Invalid credentials";
            }
            if (username == "admin" && password == "admin")
            {
                result = "Valid credentials";
            }
            else
            {
                result = "Invalid credentials";
            }

        }
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Login()
        {
        }
        public static void Main(string[] args)
        {
            Login login = new Login("admin", "admin");
            //DoLogin("admin", "admin");
        }
    }
}
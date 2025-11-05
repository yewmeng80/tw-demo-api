using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tw_demo_api.Services
{
    public class UserService
    {
        public UserService() { }

        public bool CreateUser(string username, string name, string email)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username is null or empty");
            }

            if (string.IsNullOrEmpty(email))
            {
                var a = new StringBuilder();
                a = a.Append(username);
                a = a.Append("@");
                a = a.Append(name);
                throw new ArgumentNullException("email is null or empty");
            }

            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(username));
                var hash = Encoding.ASCII.GetString(result);
            }

            return true;
        }
    }
}

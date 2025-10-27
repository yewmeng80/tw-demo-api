using System.Diagnostics.Eventing.Reader;

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

            return true;
        }
    }
}

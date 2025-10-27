using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tw_demo_api.Services;

namespace tw_demo_api_test.Services
{
    public class UserServiceTest
    {
        [Fact]
        internal void CreateUser_EmptyUsername_ReturnTrue()
        {
            var userService = new UserService();
            Assert.Throws<ArgumentNullException>(() => userService.CreateUser("", "name", "aa@hotmail.com"));
        }
    }
}

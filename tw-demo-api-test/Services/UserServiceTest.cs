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
        internal void CreateUser_EmptyUsername_ThrowArgumentNullExcpetion()
        {
            var userService = new UserService();
            Assert.Throws<ArgumentNullException>(() => userService.CreateUser("", "name", "aa@hotmail.com"));
        }

        [Fact]
        internal void CreateUser_ValidInput_ReturnTrue()
        {
            var userService = new UserService();
            var userCreated = userService.CreateUser("username", "name", "aa@hotmail.com");

            Assert.True(userCreated);

        }
    }
}

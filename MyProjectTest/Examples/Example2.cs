using MyProject.Models;
using MyProjectTest.ClassData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MyProjectTest.Exemples
{
    //Trabalhando com massa de dados
    public class Example2
    {
        private readonly ITestOutputHelper _output;

        public Example2(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory(DisplayName = "User fields are filled")]
        [MemberData(nameof(UserList))] //ideal para ler dados de excel ou banco de dados (IEnumerable)
        public void UserFielsHasContent(User user)
        {
            Assert.NotEmpty(user.Username);
            Assert.NotEmpty(user.Email);
            Assert.IsType<User>(user);
        }

        //Lista de um obj, com uma lista de parâmetros
        public static IEnumerable<object[]> UserList => new[]
        {
            new [] { new User { Id = 1, Username = "admin", Email = "admin@exemple.com"} },
            new [] { new User { Id = 2, Username = "user1", Email = "user1@exemple.com" } },
            new [] { new User { Id = 3, Username = "user2", Email = "user2@exemple.com" } },
            new [] { new User { Id = 4, Username = "user3", Email = "user3@exemple.com" } },
        };

        [Theory(DisplayName = "User fiels are filled from class")]
        [ClassData(typeof(UserListData))]
        public void UserFielsHasContentClass(User user)
        {
            Assert.NotEmpty(user.Username);
            Assert.NotEmpty(user.Email);
            Assert.IsType<User>(user);
        }
    }
}

using MyProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectTest.ClassData
{
    //Podemos ter acesso a dados a partir dessa classe
    public class UserListData : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]> 
        {
            new [] { new User { Id = 1, Username = "admin", Email = "admin@exemple.com"} },
            new [] { new User { Id = 2, Username = "user1", Email = "user1@exemple.com" } },
            new [] { new User { Id = 3, Username = "user2", Email = "user2@exemple.com" } },
            new [] { new User { Id = 4, Username = "user3", Email = "user3@exemple.com" } },
        };
        
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}

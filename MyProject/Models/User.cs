using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class User
    {
        public User() { }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public bool MaiorDeIdade()
        {
            bool result = Age >= 18 ? true : false;

            return result;
        }
    }
}

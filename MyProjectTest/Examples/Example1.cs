using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MyProjectTest.Exemples
{
    public class Example1
    {
        ITestOutputHelper _output;
        //Acesso a Logs
        public Example1(ITestOutputHelper output)
        {
            _output = output;
        }

        //TDD - Test Driven Development (Red(Falhar) - O que você deve testar
        //Green(Corrigir) - Como deve ser,
        //Refactor(Melhorar) - Revisar código)
        [Fact]
        public void UsuarioEMaiorDeIdade()
        {
            //Arrange
            var user = new User("José", 50);
            var expected = true;

            //Act
            var result = user.MaiorDeIdade();
            _output.WriteLine($"Result: {result}");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void UsuarioEMenorDeIdade()
        {
            //Arrange
            var user = new User("José", 17);
            var expected = false;

            //Act
            var result = user.MaiorDeIdade();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}

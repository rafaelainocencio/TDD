using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MyProjectTest.Examples
{
    //Trabalhando com Exceptions
    public class Example4
    {
        ITestOutputHelper _output;
        private string message = "Division by zero is not accepted";
        public Example4(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ShouldFailDivideByZero()
        {
            var ex = Assert.Throws<DivideByZeroException>(()  => ThrowAnException());
            Assert.Equal(message, ex.Message);
        }

        [Fact]
        public void ShouldFailDivideByZeroRecord()
        {
            //Arrange
            var ex = Record.Exception(() => ThrowAnException());

            //Act
            if (!(ex is DivideByZeroException))
                    Assert.True(false);

            //Assert
            Assert.Equal(message, ex.Message);
        }

        private void ThrowAnException()
        {
            throw new DivideByZeroException(message);
        }
    }
}

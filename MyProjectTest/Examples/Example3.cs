using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace MyProjectTest.Exemples
{
    //Testando Paralelismo
    public class Example3 
    {
        #region NaoCollection - Executados em paralelo
        public class Example3A //12 segundos
        {
            private readonly ITestOutputHelper _output;

            public Example3A(ITestOutputHelper output)
            {
                _output = output;
            }

            [Fact]
            public void TestLong()
            {
                _output.WriteLine("Example 3A: TestLong started");
                Thread.Sleep(6000);
            }

            [Fact]
            public void TestMedium()
            {
                _output.WriteLine("Example 3A: TestLong started");
                Thread.Sleep(4000);
            }

            [Fact]
            public void TestSmall()
            {
                _output.WriteLine("Example 3A: TestLong started");
                Thread.Sleep(2000);
            }
        }

        public class Example3B //12 segundos
        {
            private readonly ITestOutputHelper _output;

            public Example3B(ITestOutputHelper output)
            {
                _output = output;
            }

            [Fact]
            public void TestLong()
            {
                _output.WriteLine("Example 3B: TestLong started");
                Thread.Sleep(6000);
            }

            [Fact]
            public void TestMedium()
            {
                _output.WriteLine("Example 3B: TestLong started");
                Thread.Sleep(4000);
            }

            [Fact]
            public void TestSmall()
            {
                _output.WriteLine("Example 3B: TestLong started");
                Thread.Sleep(2000);
            }
        }
        #endregion

        #region Collection - 17 segundos - não executa em pararelo com classes fora da Collection

        [Collection("Serial")]
        public class Example3C //13 segundos
        {
            private readonly ITestOutputHelper _output;

            public Example3C(ITestOutputHelper output)
            {
                _output= output;
            }

            [Fact]
            public void TestMedium()
            {
                _output.WriteLine("Example 3C: TestLong started");
                Thread.Sleep(13000);
            }
        }

        [Collection("Serial")]
        public class Example3D //4 segundos
        {
            private readonly ITestOutputHelper _output;

            public Example3D(ITestOutputHelper output)
            {
                _output = output;
            }

            [Fact]
            public void TestMedium()
            {
                _output.WriteLine("Example 3D: TestLong started");
                Thread.Sleep(4000);
            }

        }
        #endregion
    }
}

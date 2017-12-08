using Xunit;
using NetCoreApiDockerHelloWorld.Controllers;

namespace Api.Tests.Controllers
{
    public class ValuesControllerTests 
    {
        private readonly ValuesController _classToTest;

        public ValuesControllerTests()
        {
            _classToTest = new ValuesController();
        }

        [Fact]
        public void GetReturnsValues()
        {
            var result = _classToTest.Get();

            Assert.NotNull(result);
        }

        [Fact]
        public void GetIdReturnsValues()
        {
            var result = _classToTest.Get(1);

            Assert.NotNull(result);
            Assert.True(result == "Hello, Number 1!"); 
        }
    }
}

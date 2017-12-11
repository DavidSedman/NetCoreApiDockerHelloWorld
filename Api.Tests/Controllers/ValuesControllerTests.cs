using Moq;
using Xunit;
using NetCoreApiDockerHelloWorld.Controllers;
using Microsoft.Extensions.Logging;

namespace Api.Tests.Controllers
{
    public class ValuesControllerTests 
    {
        private readonly ValuesController _classToTest;
        private readonly ILogger<ValuesController> _logger;
        public ValuesControllerTests()
        {
            var mock = new Mock<ILogger<ValuesController>>();
            _logger = mock.Object;
            _classToTest = new ValuesController(_logger);
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

        [Fact]
        public void GetIdReturnsNotFoundValues()
        {
            var result = _classToTest.Get(0);

            Assert.NotNull(result);
            
            Assert.True(result == "GetById(0) NOT FOUND"); 
        }
    }
}

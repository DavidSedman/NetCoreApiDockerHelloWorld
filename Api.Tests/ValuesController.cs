using Xunit;
using NetCoreApiDockerHelloWorld.Controllers;

namespace Api.Tests
{
    public class ValuesControllerTests 
    {
            private readonly ValuesController ClassToTest;

            public StartingUnitTests()
            {
                ClassToTest = new ValuesController();
            }

            [Fact]
            public void GetReturnsValues()
            {
                var result = ClassToTest.Get();

                Assert.False(result, null);
            }
    }
}

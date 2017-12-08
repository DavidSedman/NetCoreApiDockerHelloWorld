using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;
using NetCoreApiDockerHelloWorld;

namespace Api.IntegrationTests.Controllers
{
    public class ValuesControllerIntegrationTests
    {
        
        private readonly TestServer _server;
        private readonly HttpClient _client;

        public ValuesControllerIntegrationTests()
        {
            // Arrange
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task GetReturnValue()
        {
            var expected = @"[""Hello"",""World""]";

            // Act
            var response = await _client.GetAsync("api/values/");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.True(result == expected);
        }

        [Fact]
        public async Task GetIdReturnValue()
        {
            // Act
            var response = await _client.GetAsync("api/values/1");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.True(result == "Hello, Number 1!");
        }
    }
}

using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace DiamondKata.Tests.Integration.Controllers
{
    public class DiamondKataControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;

        public DiamondKataControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void Get_WithLetterA_ReturnsA()
        {
            var client = _factory.CreateClient();

            var responseBody = await client.GetStringAsync("/api/diamondkata/a");

            Assert.Equal("A", responseBody);
        }
    }
}


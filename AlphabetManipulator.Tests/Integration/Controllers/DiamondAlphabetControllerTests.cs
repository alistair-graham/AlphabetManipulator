using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace AlphabetManipulator.Tests.Integration.Controllers
{
    public class DiamondAlphabetControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;

        public DiamondAlphabetControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void Get_WithLetterA_ReturnsA()
        {
            var client = _factory.CreateClient();

            var responseBody = await client.GetStringAsync("/api/GeometricAlphabet/a");

            Assert.Equal("A", responseBody);
        }
    }
}


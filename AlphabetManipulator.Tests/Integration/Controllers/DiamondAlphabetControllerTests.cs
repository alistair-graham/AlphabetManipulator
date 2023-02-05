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

            var responseBody = await client.GetStringAsync("/api/GeometricAlphabet/A");

            Assert.Equal("A", responseBody);
        }

        // test endpoints, not supplying char, non a-z char, upper or lowercase, multiple characters
        // Maybe take some of these and do controller tests?
    }
}


using Microsoft.AspNetCore.Mvc.Testing;
using System.Diagnostics.Metrics;
using System.Net;
using Xunit;

namespace AlphabetManipulator.Tests.E2E.Controllers
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

        [Fact]
        public async void Get_WithNonAlphabeticalCharacter_ReturnsBadRequest()
        {
            var nonAlphabeticalCharacter = "5";
            var client = _factory.CreateClient();

            var response = await client.GetAsync($"/api/GeometricAlphabet/{nonAlphabeticalCharacter}");
            var responseBody = await response.Content.ReadAsStringAsync();

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
            Assert.Equal($"Must provide [A-Z] letter in the URL path, instead provided <{nonAlphabeticalCharacter}>.", responseBody);
        }

        [Fact]
        public async void Get_MultipleCharacters_ReturnsBadRequest()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync($"/api/GeometricAlphabet/ABC");

            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}


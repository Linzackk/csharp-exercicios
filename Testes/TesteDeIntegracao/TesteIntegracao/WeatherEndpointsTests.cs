using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;

namespace TesteIntegracao
{
    public class WeatherEndpointsTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public WeatherEndpointsTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }
        [Fact]
        public async Task Get_WeatherForecast_DeveRetornar200()
        {
            var response = await _client.GetAsync("/weatherforecast");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
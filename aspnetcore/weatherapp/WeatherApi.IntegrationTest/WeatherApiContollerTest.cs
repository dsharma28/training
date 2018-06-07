using System;
using System.Net.Http;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using WeatherApi.Models;
using Xunit;

namespace WeatherApi.IntegrationTest
{
   
    public class WeatherApiControllerTest : IDisposable
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public WeatherApiControllerTest()
        {
            _server = new TestServer(WebHost.CreateDefaultBuilder()
                .UseStartup<Startup>()
                .UseEnvironment("Development"));
            _client = _server.CreateClient();
        }

        public void Dispose()
        {
            _client.Dispose();
            _server.Dispose();
        }


        [Fact]
        public async void GetWeatherByZipCode_Returns_200OK()
        {
            // Act
            var response = await _client.GetAsync("/api/weather/18976");

            // Assert 200Ok
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Forecast[] forecast = JsonConvert.DeserializeObject<Forecast[]>(responseString);
            // Assert Result is Not Empty
            Assert.NotEmpty(forecast);
            // Assert Zipcode in response is same as in request
            Assert.Equal(18976,forecast[0].Zipcode);

        }

    }
}

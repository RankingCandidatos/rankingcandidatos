using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace rankingcandidatos.integration.specs
{
    public class WeatherForecastControllerTests : BaseTest
    {
        [Test]
        public async Task GetShouldReturnStatusCode200Ok()
        {
            var response = await httpClient.GetAsync("/WeatherForecast");

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}

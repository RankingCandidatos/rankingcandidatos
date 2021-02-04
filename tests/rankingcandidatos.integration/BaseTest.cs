using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using rankingcandidatos.API;
using System.IO;
using System.Net.Http;

namespace rankingcandidatos.integration
{
    public class BaseTest
    {
        public WebApplicationFactory<Startup> factory { get; private set; }
        public HttpClient httpClient { get; private set; }

        [OneTimeSetUp]
        public void SetupWebHost()
        {
            factory = new WebApplicationFactory<Startup>().WithWebHostBuilder(builder => 
            {
                builder.UseEnvironment("Test");
            });

            httpClient = factory.CreateClient();
        }
    }
}

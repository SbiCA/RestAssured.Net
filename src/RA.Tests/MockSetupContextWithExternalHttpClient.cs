using System.Net.Http;
using NUnit.Framework;

namespace RA.Tests
{
    //https://docs.microsoft.com/en-us/dotnet/articles/core/porting/libraries
    public class MockSetupContextWithExternalHttpClient
    {
        [Test]
        public void SetExternalHttpClientInstanceInSetupContext()
        {
            var httpClient = new HttpClient();
            var setupContext = new SetupContext();

            setupContext.HttpClient(httpClient);

            Assert.AreEqual(httpClient, setupContext.HttpClient());
        }

        [Test]
        public void UsingDefaultHttpClientInSetupContext()
        {
            var setupContext = new SetupContext();

            var httpClient = setupContext.HttpClient();
          
            Assert.IsNotNull(httpClient);
        }
    }
}
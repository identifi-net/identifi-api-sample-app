using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IdentifiAPISampleApplication {
    /// <summary>
    /// This simple base class is inherited by all the NSwagStudio-generated proxy classes. It provides a nice hook to setup HTTP headers for all server calls made by the generated proxies.
    /// </summary>
    public class SampleClientBase {

        public static string apiKey { get; set; }

        protected Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken) {
            // Add the api-key header to every HTTP request for authentication purposes
            var request = new HttpRequestMessage();
            request.Headers.Add("api-key", apiKey);
            return Task.FromResult(request);
        }

    }

}

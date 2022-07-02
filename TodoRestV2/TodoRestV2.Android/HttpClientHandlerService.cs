using System.Net.Http;
using TodoRestV2.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(HttpClientHandlerService))]
namespace TodoRestV2.Droid
{
    public class HttpClientHandlerService : IHttpClientHandlerService
    {

        public HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) =>
                {
                    if (cert.Issuer.Equals("CN=localhost"))
                        return true;
                    return errors == System.Net.Security.SslPolicyErrors.None;
                };
            return handler;
        }

    }
}


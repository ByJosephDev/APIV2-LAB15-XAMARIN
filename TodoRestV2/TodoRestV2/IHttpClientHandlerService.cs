using System.Net.Http;

namespace TodoRestV2
{
    public interface IHttpClientHandlerService
    {

        HttpClientHandler GetInsecureHandler();

    }
}


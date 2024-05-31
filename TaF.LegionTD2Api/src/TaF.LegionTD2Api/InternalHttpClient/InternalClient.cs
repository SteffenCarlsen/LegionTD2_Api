using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TaF.LegionTD2Api.InternalHttpClient.Exceptions;

namespace TaF.LegionTD2Api.InternalHttpClient;

public partial class InternalClient
{
    private const string BaseUrl = "https://apiv2.legiontd2.com";

    public InternalClient(string apikey)
    {
        HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "TaFLegionTD2API");
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apikey);
    }

    public HttpClient HttpClient { get; }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        if (endpoint == null)
        {
            throw new ArgumentException("You must supply a valid endpoint", nameof(endpoint));
        }

        if (string.IsNullOrEmpty(endpoint))
        {
            throw new InvalidUrlException();
        }

        var clientRequest = new ClientRequestEventArgs
        {
            Url = BaseUrl + endpoint
        };

        // fire a BeforeRequest event
        await OnBeforeRequestAsync(clientRequest);
        OnBeforeRequest(clientRequest);

        var response = string.Empty;
        if (string.IsNullOrEmpty(clientRequest.ResponseContent))
        {
            try
            {
                var httpResponse = await HttpClient.GetAsync(clientRequest.Url);
                response = await httpResponse.Content.ReadAsStringAsync();
                clientRequest.ResponseContent = response;

                if (httpResponse.IsSuccessStatusCode)
                {
                    // fire a CompletedRequest event
                    await OnCompletedRequestAsync(clientRequest);
                    OnCompletedRequest(clientRequest);
                }
                else
                {
                    throw new ApplicationException("Non 200 responsecode received, most likely limited by API");
                }
            }
            catch (Exception e)
            {
                // if a non success status code (200) is returned then try to deserialize the error
                var errorResponseDto = JsonConvert.DeserializeObject<ErrorResponseDto>(response);

                var clientRequestError = new ClientRequestErrorEventArgs(response.Contains("Forbidden") ? 400 : 200, errorResponseDto.message);

                // fire a ErrorRequest event
                await OnErrorRequestAsync(clientRequestError);
                OnErrorRequest(clientRequestError);

                return default;
            }
        }
        else // an event supplied the response body (a cache?)
        {
            response = clientRequest.ResponseContent;
        }

        // fire a SuccessRequest event
        await OnSuccessRequestAsync(clientRequest);
        OnSuccessRequest(clientRequest);

        var responseDto = JsonConvert.DeserializeObject<T>(response);
        return responseDto;
    }
}
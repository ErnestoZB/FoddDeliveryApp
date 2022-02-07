using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.Web.Api.Client.Implementation
{
    public abstract class BaseApiClient
    {

        private static string ApiHost = "https://10.0.2.2:44330/";


#if DEBUG
        private static readonly HttpClientHandler insecureHandler = GetInsecureHandler();
        private static readonly HttpClient _client = new HttpClient(insecureHandler)
        {
            BaseAddress = new Uri(ApiHost)
        };
#else
        private static readonly HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri(ApiHost)
        };
#endif
        protected static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

        // This method must be in a class in a platform project, even if
        // the HttpClient object is constructed in a shared project.
        public static HttpClientHandler GetInsecureHandler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert.Issuer.Equals("CN=localhost"))
                    return true;
                return true;
            };
            return handler;
        }

        private static async Task<HttpContent> ValueAsHttpContent(object value)
        {
            var jsonParams = await Task.Run(() => JsonConvert.SerializeObject(value, Formatting.None, JsonSettings));

            return new StringContent(jsonParams, System.Text.Encoding.UTF8, "application/json");
        }

        private static async Task<T> HttpContentAsValue<T>(HttpContent content)
        {
            var responseContent = await content.ReadAsStringAsync();

            return await Task.Run(() => JsonConvert.DeserializeObject<T>(responseContent, JsonSettings));
        }

        private async static Task<HttpRequestMessage> CreateRequestMessage(HttpMethod method, string requestUri, Dictionary<string, string> headers, object content)
        {
            var httpRequestMessage = new HttpRequestMessage(method, requestUri)
            {
                Version = HttpVersion.Version10,
            };

            if (content != null)
            {
                httpRequestMessage.Content = await ValueAsHttpContent(content);
            }

            if (headers != null)
            {
                foreach (var key in headers.Keys)
                {
                    headers.TryGetValue(key, out string value);

                    httpRequestMessage.Headers.Add(key, value);
                }
            }

            return httpRequestMessage;
        }

        protected async Task<T> GetItem<T>(string requestUri, Dictionary<string, string> headers = null, object content = null)
        {
            try
            {
                var httpRequestMessage = await CreateRequestMessage(HttpMethod.Get, requestUri, headers, content);

                using (HttpResponseMessage response = await _client.SendAsync(httpRequestMessage))
                {
                    return await HttpContentAsValue<T>(response.Content);
                }
            }
            catch (Exception ex)
            {
                return (T)Activator.CreateInstance(typeof(T));
            }
        }

        protected async Task<T> PostItem<T>(string requestUri, Dictionary<string, string> headers = null, object content = null)
        {
            try
            {
                var httpRequestMessage = await CreateRequestMessage(HttpMethod.Post, requestUri, headers, content);

                using (HttpResponseMessage response = await _client.SendAsync(httpRequestMessage))
                {
                    return await HttpContentAsValue<T>(response.Content);
                }
            }
            catch (Exception ex)
            {
                return (T)Activator.CreateInstance(typeof(T));
            }
        }
    }
}

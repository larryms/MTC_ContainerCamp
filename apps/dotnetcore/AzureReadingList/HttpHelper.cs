using AzureReadingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AzureReadingList
{
    public class HttpHelper
    {
        private string webUrl;
        private String responseString;

        public HttpHelper(string url)
        {
            webUrl = url;
        }

        public async Task<string> GetResponse()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, string.Concat(Settings.EndPoint, webUrl));
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

        public async Task<string> PostRequest(string content)
        {

        }
    }
}

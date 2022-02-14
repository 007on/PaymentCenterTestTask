using PaymentCenterTestTask.Configs;
using PaymentCenterTestTask.Data.BroPayApi;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PaymentCenterTestTask.Clients {
    public class BroPayApiClient : IBroPayApiClient {
        private readonly HttpClient _httpClient;

        public BroPayApiClient(BroPayConfig config) {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(config.Url);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> SendRequest(string method, PayRequestBase request) {
            var response = await _httpClient.PostAsJsonAsync(method, request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}

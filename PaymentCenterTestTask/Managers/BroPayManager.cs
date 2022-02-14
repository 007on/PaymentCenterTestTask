using Newtonsoft.Json;
using PaymentCenterTestTask.Clients;
using PaymentCenterTestTask.Data.BroPayApi;
using System.Threading.Tasks;

namespace PaymentCenterTestTask.Managers {
    public class BroPayManager : IBroPayManager {
        private readonly string _payMethodName = "/pay";
        private readonly string _payoutMethodName = "/payout";
        private readonly IBroPayApiClient _broPayApiClient;

        public BroPayManager(IBroPayApiClient broPayApiClient) {
            _broPayApiClient = broPayApiClient;
        }

        public async Task<PayResponse> SendPayRequest(PayRequest payRequest) {
            var jsonResult = await _broPayApiClient.SendRequest(_payMethodName, payRequest);

            return JsonConvert.DeserializeObject<PayResponse>(jsonResult);
        }

        public async Task<PayoutResponse> SendPayoutRequest(PayoutRequest payoutRequest) {
            var jsonResult = await _broPayApiClient.SendRequest(_payoutMethodName, payoutRequest);

            return JsonConvert.DeserializeObject<PayoutResponse>(jsonResult);
        }
    }
}
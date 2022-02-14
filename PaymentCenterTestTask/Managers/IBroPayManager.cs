using PaymentCenterTestTask.Data.BroPayApi;
using System.Threading.Tasks;

namespace PaymentCenterTestTask.Managers {
    public interface IBroPayManager {
        Task<PayoutResponse> SendPayoutRequest(PayoutRequest payoutRequest);
        Task<PayResponse> SendPayRequest(PayRequest payRequest);
    }
}
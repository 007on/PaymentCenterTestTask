using PaymentCenterTestTask.Data.BroPayApi;
using System.Threading.Tasks;

namespace PaymentCenterTestTask.Clients {
    public interface IBroPayApiClient {
        Task<string> SendRequest(string method, PayRequestBase request);
    }
}
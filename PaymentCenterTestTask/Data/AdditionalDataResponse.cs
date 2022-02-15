using System;

namespace PaymentCenterTestTask.Data {
    public class AdditionalDataResponse {
        public string SessionId { get; set; }

        public TimeSpan SessionExpire { get; set; }

        public DateTime SessionExpireDate { get; set; }

        public DateTime ServerTime { get; set; }
    }
}
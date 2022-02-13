using System;

namespace PaymentCenterTestTask.Data.Messages.TypedMessages {
    public class ReauthResponse {
        public byte[] EncryptedKey { get; set; }

        public byte[] InitializationVector { get; set; }

        public string SessionId { get; set; }

        public TimeSpan SessionExpire { get; set; }

        public DateTime SessionExpireDate { get; set; }

        public DateTime ServerTime { get; set; }
    }
}

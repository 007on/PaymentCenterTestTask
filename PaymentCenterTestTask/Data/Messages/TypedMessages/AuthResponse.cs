using System;

namespace PaymentCenterTestTask.Data.Messages.TypedMessages {
    public class AuthResponse {
        public byte[] EncryptedKey { get; set; }

        public byte[] HotpKey { get; set; }

        public string TokenId { get; set; }

        public string SessionId { get; set; }

        public TimeSpan SessionExpire { get; set; }

        public DateTime SessionExpireDate { get; set; }

        public DateTime ServerTime { get; set; }
    }
}
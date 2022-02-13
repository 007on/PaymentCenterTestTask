namespace PaymentCenterTestTask.Data.Messages.TypedMessages {
    public class ReauthRequest {
        public string Login { get; set; }

        public string TokenId { get; set; }

        public string Hotp { get; set; }

        public bool Encrypted { get; set; }

        public byte[] PublicKey { get; set; }
    }
}
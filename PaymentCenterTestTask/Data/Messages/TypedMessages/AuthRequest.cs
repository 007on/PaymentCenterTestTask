namespace PaymentCenterTestTask.Data.Messages.TypedMessages {
    public class AuthRequest {
        public string Login { get; set; }

        public byte[] Password { get; set; }

        public string DeviceId { get; set; }

        public bool Encrypted { get; set; }

        public byte[] PublicKey { get; set; }
    }
}
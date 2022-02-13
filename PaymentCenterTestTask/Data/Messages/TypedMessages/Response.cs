namespace PaymentCenterTestTask.Data.Messages.TypedMessages {
    public class Response {
        public string ResultCode { get; set; }

        public object Result { get; set; }

        public Error Error { get; set; }
    }
}
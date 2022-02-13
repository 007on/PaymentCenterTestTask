namespace PaymentCenterTestTask.Data.Messages.TypedMessages {
    public class Request {
        public string Type { get; set; }

        public object Payload { get; set; }

        public RequestPriority Priority { get; set; }
    }
}
namespace PaymentCenterTestTask.Data.Messages {
    public class GeneralMessage {        
        public MessageType Type { get; set; }

        public string CorrelationId { get; set; }

        public object Payload { get; set; }
    }
}
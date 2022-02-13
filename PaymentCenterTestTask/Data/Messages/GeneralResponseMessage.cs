using System;

namespace PaymentCenterTestTask.Data.Messages {
    public class GeneralResponseMessage : GeneralMessage {
        public GeneralResponseMessage() {
            Type = MessageType.Response;
        }

        public TimeSpan TTL { get; set; }
    }
}
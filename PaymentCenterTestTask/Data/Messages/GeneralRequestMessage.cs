using System;

namespace PaymentCenterTestTask.Data.Messages {
    public class GeneralRequestMessage : GeneralMessage {
        public GeneralRequestMessage() {
            Type = MessageType.Request;
        }
        
        public DateTime TimeStamp { get; set; }
    }
}
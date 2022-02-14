namespace PaymentCenterTestTask.Data.BroPayApi {
    /// <summary>
    /// Запрос на однопроходное списание
    /// </summary>
    public class PayRequest : PayRequestBase {

        /// <summary>
        /// Url адрес по которому мерчант будет перенаправлен после 
        /// завершения операции
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
namespace PaymentCenterTestTask.Data.BroPayApi {
    /// <summary>
    /// Ответ на однопроходное списание
    /// </summary>
    public class PayResponse : PayResponseBase {

        /// <summary>
        /// Url адрес по которому мерчанту необходимо перейти GET'ом для 
        /// продолжения процесса оплаты
        /// </summary>
        public string PaymentUrl { get; set; }
    }
}
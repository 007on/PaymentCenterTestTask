namespace PaymentCenterTestTask.Data.BroPayApi {
    /// <summary>
    /// Информация по банковской карте
    /// </summary>
    public class CardInfo {
        /// <summary>
        /// Номер карты
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Держатель карты
        /// </summary>
        public string CardHolder { get; set; }

        /// <summary>
        /// Год окончания срока действия карты
        /// </summary>
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Месяц окончания срока действия карты
        /// </summary>
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Cvv - код
        /// </summary>
        public string Cvv { get; set; }
    }
}
namespace PaymentCenterTestTask.Data.BroPayApi {
    public class PayRequestBase{
        /// <summary>
        /// Уникальный идентификатор операции со стороны Мерчанта
        /// </summary>
        public string ExtId { get; set; }

        /// <summary>
        /// Сумма, указанная в минимальных единицах валюты
        /// </summary>
        public long Amount { get; set; }

        /// <summary>
        /// Валюта операции
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Информация по банковской карте
        /// </summary>
        public CardInfo CardInfo { get; set; }
    }
}
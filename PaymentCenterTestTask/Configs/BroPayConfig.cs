using Newtonsoft.Json;
using System.IO;

namespace PaymentCenterTestTask.Configs {
    public class BroPayConfig {
        public BroPayConfig() {
            var json = File.ReadAllText("BroPayUrls");
            var config = JsonConvert.DeserializeAnonymousType(
                json,
                new { TestMode = false, TestUrl = "", ProdUrl = "" }
            );
            Url = config.TestMode ? config.TestUrl : config.ProdUrl;
        }

        public string Url { get; }
    }
}
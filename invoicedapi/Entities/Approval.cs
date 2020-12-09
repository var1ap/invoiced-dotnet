using Newtonsoft.Json;

namespace Invoiced
{
    public class Approval : AbstractItem
    {
        [JsonProperty("id")] public long? Id { get; set; }

        [JsonProperty("ip")] public string Ip { get; set; }

        [JsonProperty("timestamp")] public long? Timestamp { get; set; }

        [JsonProperty("user_agent")] public string UserAgent { get; set; }

        protected override string EntityId()
        {
            return Id.ToString();
        }
    }
}
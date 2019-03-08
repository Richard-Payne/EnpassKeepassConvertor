using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class FieldHistoricValue 
    {
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }
        public string Value { get; set; }
    }

}
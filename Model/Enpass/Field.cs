using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class Field 
    {
        string Label { get; set; }
        int Order { get; set; } 
        [JsonConverter(typeof(BoolConverter))]
        bool Sensitive { get; set; } 
        string Type { get; set; } 
        int UID { get; set; } 
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }
        public string Value { get; set; }
        [JsonProperty("value_updated_at")]
        public long ValueUpdatedAt { get; set; }

        [JsonProperty]
        public List<FieldHistoricValue> History { get; set; }
    }

}
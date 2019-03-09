using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class Field 
    {
        public string Label { get; set; }
        public int Order { get; set; } 
        [JsonConverter(typeof(BoolConverter))]
        public bool Sensitive { get; set; } 
        public string Type { get; set; } 
        public int UID { get; set; } 
        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }
        public string Value { get; set; }
        [JsonProperty("value_updated_at")]
        public long ValueUpdatedAt { get; set; }

        [JsonProperty]
        public List<FieldHistoricValue> History { get; set; }
    }

}
using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class Folder 
    {
        public string Icon { get; set; }
        [JsonProperty("parent_uuid")]
        public string ParentUuid { get; set; }
        public string Title { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        [JsonProperty("update_at")]
        public string UpdatedAt { get; set; }
        public string Uuid { get; set; }
    }

}
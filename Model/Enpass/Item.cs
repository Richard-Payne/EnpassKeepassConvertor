using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class Item 
    {
        [JsonProperty("auto_submit")]
        [JsonConverter(typeof(BoolConverter))]
        public bool AutoSubmit { get; set; }
        public string Category { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool Favorite { get; set; }
        public Icon Icon { get; set; }
        public string Note { get; set; }
        public string  Subtitle { get; set; }
        [JsonProperty("template_type")]
        public string TemplateType { get; set; }
        public string Title { get; set; }
        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; } 
        public string Uuid { get; set; } 

        public List<Field> Fields { get; set; }
    }

}
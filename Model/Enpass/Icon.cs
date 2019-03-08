using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class Icon 
    {
        public string Fav { get; set; }
        public Image Image { get; set; }
        public int Type { get; set; }
        public string Uuid { get; set; }
    }

}
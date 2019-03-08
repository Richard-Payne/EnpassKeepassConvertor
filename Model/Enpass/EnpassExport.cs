using System.Collections.Generic;
using Newtonsoft.Json;

namespace EnpassKeepassConverter.Model.Enpass
{
    [JsonObject]
    internal class EnpassExport 
    {
        public List<Folder> Folders { get; set; }
        public List<Item> Items { get; set; }
    }

}
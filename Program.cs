using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using EnpassKeepassConverter.Model.Enpass;

namespace EnpassKeepassConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(args[0]);
            var export = JsonConvert.DeserializeObject<EnpassExport>(json);

        }
    }
}

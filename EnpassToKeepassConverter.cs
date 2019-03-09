using System;
using System.Collections.Generic;
using System.Linq;
using EnpassKeepassConverter.Model.Enpass;
using EnpassKeepassConverter.Model.Keepass;

namespace EnpassKeepassConverter
{
    public class EnpassToKeepassConverter
    {
        public KeepassImport Convert(EnpassExport enpassExport, Func<Item, IEnumerable<Field>, Field> ConflictResolver)
        {
            var import = new KeepassImport();
            
            foreach(var item in enpassExport.Items)
            {
                var urls = item.Fields.Where(f => f.Type.ToLower() == "url");
                var url = urls.Count() > 1
                    ? ConflictResolver(item, urls)
                    : urls.First();

                var keepassLogin = new Login {
                    Title = item.Title,

                }
            }
        }
    }
}
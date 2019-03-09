using System.Collections.Generic;

namespace EnpassKeepassConverter.Model.Keepass
{
    public class KeepassImport 
    {
        public KeepassImport()
        {
            Logins = new List<Login>();
        }
        
        public List<Login> Logins {get ;set;}
    }
}
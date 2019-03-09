using System.Collections.Generic;

namespace EnpassKeepassConverter.Model.Keepass
{
    public class Login
    {
        public string Title { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public List<string> Notes { get; set; }
    }
}
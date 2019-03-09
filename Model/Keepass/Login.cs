using System.Collections.Generic;

namespace EnpassKeepassConverter.Model.Keepass
{
    public class Login
    {
        string Title { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Url { get; set; }
        List<string> Notes { get; set; }
    }
}
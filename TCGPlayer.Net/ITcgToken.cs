using System;

namespace TCGPlayer.Net
{
    public interface ITcgToken
    {
        string AccessToken { get; set; }
        string TokenType { get; set; }
        long ExpiresIn { get; set; }
        string UserName { get; set; }
        DateTime Issued { get; set; }
        DateTime Expires { get; set; }
        string UserAgent { get; set; }
    }
}

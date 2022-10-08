using audits_.net_react_ramine.Models;

namespace audits_.net_react_ramine.Response;

public class LoginResult
{
    public User User { get; set; }
    public string Token { get; set; }
}

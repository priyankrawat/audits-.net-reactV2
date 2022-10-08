using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Controllers;

[Authorize]
public class ApplicationController : ControllerBase
{
    protected UserContext UserContext { get; set; }
    public ApplicationController(UserContext userContext)
    {
        UserContext = userContext;
    }

    public async Task<User?> CurrentUser()
    {
        string? userId = User.FindFirst("id")?.Value;
        if(userId is null)
        {
            return null;
        }
        return await UserContext.Users.FirstOrDefaultAsync(x => x.Id == int.Parse(userId));
    }
}

using audits_.net_react_ramine.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace audits_.net_react_ramine.Controllers;

[Authorize]
public class ApplicationController : ControllerBase
{
    protected UserContext UserContext { get; set; }
    public ApplicationController(UserContext userContext)
    {
        UserContext = userContext;
    }
}

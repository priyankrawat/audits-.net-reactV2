using Microsoft.AspNetCore.Mvc;

namespace audits_.net_react_ramine.Controllers;

[ApiController]
[Route("/api/home")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Index()
    {
        return "David Joe";
    }
}

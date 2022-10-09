using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectsController : ApplicationController
{
	public ProjectsController(AuditsDbContext auditsDbContext) : base(auditsDbContext)
    {
	}

	[HttpGet]
	public async Task<ActionResult<List<Project>>> GetProjects()
	{
		return await AuditsDbContext.Projects.ToListAsync();
	}
}
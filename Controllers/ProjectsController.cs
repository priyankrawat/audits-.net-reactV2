using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Controllers;

[ApiController]
[Route("api/projects")]
public class ProjectsController : ApplicationController
{
	private readonly ProjectContext _projectContext;
	public ProjectsController(ProjectContext projectContext, UserContext userContext) : base(userContext)
    {
		_projectContext = projectContext;
	}

	[HttpGet]
	public async Task<ActionResult<List<Project>>> GetProjects()
	{
		return await _projectContext.Projects.ToListAsync();
	}
}
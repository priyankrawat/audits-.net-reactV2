using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using audits_.net_react_ramine.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace audits_.net_react_ramine.Controllers;

[ApiController]
[Route("/api/audits")]
public class AuditsController : ApplicationController
{
    public AuditsController(AuditsDbContext auditsDbContext) : base(auditsDbContext)
	{
	}

    [HttpGet]
    [Authorize]
    public async Task<ActionResult<List<Audit>>> GetAudits() => await AuditsDbContext.Audits.ToListAsync();

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<List<Audit>>> FilterAudits(AuditRequest filter)
    {
        List<Audit> records = new();
        if (filter.Query.Filters.Valid())
            records = await AuditsDbContext.Audits.Where(x => x.Message.ToLower().Contains(filter.Query.Filters.Message.ToLower())).ToListAsync();
        else
            records = await AuditsDbContext.Audits.ToListAsync();

        return records;
    }
}
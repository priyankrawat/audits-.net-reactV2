using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using audits_.net_react_ramine.Requests;
using Baseline;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
    public async Task<ActionResult<List<Audit>>> FilterAudits([FromBody(EmptyBodyBehavior = EmptyBodyBehavior.Allow)] AuditRequest? filter)
    {
        var query = "SELECT * FROM audits";

        var filter_parts = new List<string>();

        if (filter?.Query.Filters.Message != null)
        {
            filter_parts.Add($"message ILIKE '{filter.Query.Filters.Message}%'");
        }
        else 
        {
            if(filter?.Query?.Filters?.Status != null)
            {
                filter_parts.Add($"status='{filter.Query.Filters.Status}'");
            }
        }

        if(filter_parts.Any())
        {
            query += $"\nWHERE {filter_parts.Join(" AND ")}";
        }

        var records = await AuditsDbContext.Audits.FromSqlRaw(query).ToListAsync();

        return records;
    }
}
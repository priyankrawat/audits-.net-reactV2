using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using audits_.net_react_ramine.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace audits_.net_react_ramine.Controllers;

[ApiController]
[Route("/api/settings")]
[Authorize]
public class SettingsController : ApplicationController
{
    public SettingsController(AuditsDbContext auditsDbContext) : base(auditsDbContext)
    {
    }

    [HttpGet]
    public async Task<ActionResult<Setting[]>> IndexAsync()
    {
        var currentUser = await CurrentUser();
        return new[] { new Setting { DailyEmailUpdates = currentUser.DailyEmailUpdates ?? false } };
    }

    [HttpPut("{settingName}")]
    public async Task<ActionResult<bool>> UpdateAsync([FromRoute] string settingName, [FromBody] SettingRequest request)
    {
        var currentUser = await CurrentUser();
        var command = $"UPDATE users SET {settingName} = @value WHERE users.id = @userId";
        NpgsqlParameter valueSqlParams;
        if (request.Value is null)
        {
            valueSqlParams = new NpgsqlParameter("@value", DBNull.Value);
        }
        else
        {
            if (settingName == "daily_email_updates")
            {
                valueSqlParams = new NpgsqlParameter("@value", bool.Parse(request.Value.ToString()!));
            }
            else
            {
                valueSqlParams = new NpgsqlParameter("@value", request.Value.ToString());
            }
        }
        var userIdSqlParams = new NpgsqlParameter("@userId", currentUser!.Id);
        var result = await AuditsDbContext.Database.ExecuteSqlRawAsync(command, new[]
        {
            valueSqlParams,
            userIdSqlParams
        });

        return result > 0;
    }
}
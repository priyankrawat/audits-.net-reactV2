using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using audits_.net_react_ramine.Requests;
using audits_.net_react_ramine.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Reflection;

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
        return new[] { currentUser.Setting };
    }

    [HttpPut("{settingName}")]
    public async Task<ActionResult<bool>> UpdateAsync([FromRoute] string settingName, [FromBody] SettingRequest request)
    {
        if (request.Value is null)
        {
            return default;
        }

        var currentUser = await CurrentUser();
        var setting = currentUser.Setting ?? new Setting
        {
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        var prop = setting.GetType()
                .GetProperty(SnakeCaseToPascalCase(settingName));
        var value = Convert.ChangeType(request.Value?.ToString(), prop.PropertyType);
        prop.SetValue(setting, value, null);

        currentUser.Setting = setting;
        return await AuditsDbContext.SaveChangesAsync() > 0;
    }

    private static string SnakeCaseToPascalCase(string str)
    {
        return string.Concat(
            str.Split('_')
            .Select(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase)
        );
    }
}
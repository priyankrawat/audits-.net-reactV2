using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using audits_.net_react_ramine.Requests;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Shouldly;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text;

namespace audits_.net_react_ramine.Tests;

public class AuditsControllerTests
{
    [Fact]
    public async Task GetAudits()
    {
        var configPath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

        using var application = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureAppConfiguration((context, conf) =>
                {
                    conf.AddJsonFile(configPath);
                });
            });

        var client = application.CreateClient();
        using var scope = application.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AuditsDbContext>();
        var config = scope.ServiceProvider.GetRequiredService<IConfiguration>();

        // clean table
        db.Users.RemoveRange(db.Users.ToList());

        User user = new()
        {
            Id = 1,
            Email = "test@example.com",
            Password = "password",
            FirstName = "first",
            LastName = "last"
        };
        db.Users.Add(user);

        db.SaveChanges();

        var token = GenerateToken(user, config);

        AuditRequest? request = null;

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        var response = await client.PostAsJsonAsync("/api/audits", request);

        response.StatusCode.ShouldBe(HttpStatusCode.OK);
    }

    private static string GenerateToken(User user, IConfiguration config)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Email),
            new Claim("id", user.Id.ToString())
        };

        var token = new JwtSecurityToken(config["Jwt:Issuer"],
            config["Jwt:Audience"],
            claims,
            expires: DateTime.Now.AddMinutes(15),
            signingCredentials: credentials);


        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
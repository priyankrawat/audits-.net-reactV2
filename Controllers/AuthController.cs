using audits_.net_react_ramine.Data;
using audits_.net_react_ramine.Models;
using audits_.net_react_ramine.Requests;
using audits_.net_react_ramine.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace audits_.net_react_ramine.Controllers;

[ApiController]
[Route("auth")]
public class AuthController : ApplicationController
{
    private readonly IConfiguration _config;
    public AuthController(IConfiguration config, AuditsDbContext auditsDbContext) : base(auditsDbContext)
    {
        _config = config;
    }

    [HttpPost("login")]
    [AllowAnonymous]
    public async Task<ActionResult<LoginResult>> Login([FromBody] LoginRequest request)
    {
        var user = await AuditsDbContext.Users.FirstOrDefaultAsync(x => x.Email == request.Email && x.Password == request.Password);
        if (user == null)
        {
            return Unauthorized("Unauthorized");
        }

        var token = GenerateToken(user);
        return new LoginResult
        {
            User = user,
            Token = token
        };
    }

    [HttpGet("me")]
    [Authorize]
    public async Task<ActionResult<User>> Me()
    {
        var user = await CurrentUser();
        if (user is null)
        {
            return Ok(new {});
        }

        return user;
    }

    private string GenerateToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Email),
            new Claim("id", user.Id.ToString())
        };

        var token = new JwtSecurityToken(_config["Jwt:Issuer"],
            _config["Jwt:Audience"],
            claims,
            expires: DateTime.Now.AddMinutes(15),
            signingCredentials: credentials);


        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
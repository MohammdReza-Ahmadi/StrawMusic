using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Helios.Application.Common.Interfaces.Authentication;
using Helios.Domain.User;
using Microsoft.IdentityModel.Tokens;

namespace Helios.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GeneratorToken(User user)
    {

         var signinKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("the hello"));
        var sigingCoredentials = new SigningCredentials(signinKey,SecurityAlgorithms.HmacSha256);
                var claims = new []
        {
            new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName,user.FirstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };
        
        var SecurityToken = new JwtSecurityToken(
            issuer:"Helios",
            audience: "Helios",
            expires: DateTime.UtcNow,
            claims: claims,
            signingCredentials: sigingCoredentials);

            return new JwtSecurityTokenHandler().WriteToken(SecurityToken);
    }
}
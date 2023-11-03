using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using StrawMusic.Application.Common.Interfaces.Authentication;
using StrawMusic.Application.Common.Interfaces.Services;
using StrawMusic.Domain.UserEntity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace StrawMusic.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
        private readonly JwtSettings _jwtSettings;
    private readonly IDateTimeProvider _dateTimeProvider;
    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> jwtOptions)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtOptions.Value;
    }

    public string GeneratorToken(UserEntity user)
    {

         var signinKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
        var sigingCoredentials = new SigningCredentials(signinKey,SecurityAlgorithms.HmacSha256);
                var claims = new []
        {
            new Claim(JwtRegisteredClaimNames.Sub,user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName,user.FirstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, user.LastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };
        
        var SecurityToken = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
            claims: claims,
            signingCredentials: sigingCoredentials);

            return new JwtSecurityTokenHandler().WriteToken(SecurityToken);
    }
}
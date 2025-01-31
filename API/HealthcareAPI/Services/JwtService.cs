using System.Text;
using System;

public class JwtService
{
    private readonly IConfiguration _configuration;
    private readonly SigningCredentials _signingCredentials;

    public JwtService(IConfiguration configuration)
    {
        _configuration = configuration;
        _signingCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])), SecurityAlgorithms.HmacSha256);
    }

    public string GenerateToken(User user)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role.Name)
        };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(1),
            Issuer = _configuration["Jwt:Issuer"],
            Audience = _configuration["Jwt:Audience"],
            SigningCredentials = _signingCredentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}

using DAL.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Recettes_Sardaigne.Tools
{
    public class TokenManager
    {
        public static string key = "ùmprseqoiç!èt(^ùu'mzilq=rrzeosfd'(§è!çà)-mlkjhgfdswxcvbn,;123";
        public string GenerateToken(Users u)
        {
            //Je génère la clé de signature de mon token
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            //Création des data contenus dans le token
            Claim[] myClaims = new[]
            {
                new Claim(ClaimTypes.Name, u.Pseudo),
                new Claim(ClaimTypes.Role, u.Pseudo == "TestUser" ? "admin" : "users"),
                new Claim("Id_user", u.Id_user.ToString())
            };

            JwtSecurityToken jwt = new JwtSecurityToken(
                claims: myClaims,
                signingCredentials: credentials,
                expires: DateTime.UtcNow.AddDays(1)
                );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.WriteToken(jwt);


        }
    }
}

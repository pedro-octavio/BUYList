using BUYList.Application.DTOs;
using BUYList.Application.Interfaces;
using BUYList.Domain;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace BUYList.Application.Services
{
    public class TokenApplicationService :
    ITokenApplicationService
    {
        private readonly IUserApplicationService _userApplicationService;

        public TokenApplicationService
        (IUserApplicationService userApplicationService) => _userApplicationService = userApplicationService;

        public string GenerateToken
        (UserDTO userDTO)
        {
            try
            {
                var userBase = _userApplicationService.GetByEmail(userDTO.Email);

                if (userDTO.Password == userBase.Password && userDTO.Email == userBase.Email)
                {
                    var key = Encoding.ASCII.GetBytes(Settings.Secret);

                    var subject = new ClaimsIdentity
                    (new GenericIdentity(userBase.Id.ToString(), "Login"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim(JwtRegisteredClaimNames.UniqueName, userBase.Id.ToString())
                    });

                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = subject,
                        Expires = DateTime.UtcNow.AddHours(2),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };

                    var tokenHandler = new JwtSecurityTokenHandler();

                    var token = tokenHandler.CreateToken(tokenDescriptor);

                    return tokenHandler.WriteToken(token);
                }
                else throw new Exception("Incorrect email or password.");
            }
            catch
            (Exception ex)
            {
                throw ex;
            }
        }
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Talabat.BLL.Interfaces;
using Talabat.DAL.Entities.Identity;

namespace Talabat.BLL.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration configuration;

        /// we inject IConfiguration as we want to use the "Startup"
        public TokenService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        /// create the token function
        public async Task<string> CreateToken(AppUser user, UserManager<AppUser> userManager) 
        {
            /* --- jwt Token claims/payload---
             - definition:
                - claims are pieces of information asserted about a subject
                 - The claims in a JWT are encoded as a JSON object that is used as the payload of a JSON Web Signature (JWS) structure
                or as the plain-text of a JSON Web Encryption (JWE) structure
                 - make the encrypted token more complicated 

             - consist of:
                - private claims (user defined)
                - registerd claims (built-in)
             */

            /* ---final token---
             - consist of:
                - header: alg
                - payload/claims: registers or private
                - key
             */

            /// add the PrivateClaims (UserDefined)
            var authClaims = new List<Claim>() 
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.GivenName, user.DisplayName),
            };
            /// add user roles in the claims --PrivateClaims--
            var userRoles = await userManager.GetRolesAsync(user);
            foreach (var role in userRoles)
                authClaims.Add(new Claim(ClaimTypes.Role, role.ToString()));

            
            /// add key
            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]));


            /// final token
            var token = new JwtSecurityToken (
                ///registerd claims
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(double.Parse(configuration["JWT:DurationInDays"])),
                ///private claims
                claims: authClaims,
                ///key + alg
                signingCredentials: new SigningCredentials(authKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

     
    }
}

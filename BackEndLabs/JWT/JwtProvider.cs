﻿using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BackEndLabs.JWT
{
    public class JwtProvider(IOptions<JWTConfiguration> options) : IJwtProvider
    {
        private readonly JWTConfiguration _jwtConfiguration = options.Value;

        public string CreateNewToken(int userId)
        {
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_jwtConfiguration.SecretKey)
                    ), 
                SecurityAlgorithms.HmacSha384);


            Claim[] claims = [
                new(_jwtConfiguration.UserIdentity, userId.ToString()),
                ];


            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.UtcNow.AddMinutes(_jwtConfiguration.ExpiresMinutes),
                issuer: _jwtConfiguration.Issuer,
                audience: _jwtConfiguration.Audience
            );

            

            return new JwtSecurityTokenHandler()
                .WriteToken(token);
        }
    }
}
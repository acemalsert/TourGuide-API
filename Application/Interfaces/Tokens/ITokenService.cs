﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Interfaces.Tokens
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(User user, IList<string> roles);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken();
    }
}

﻿using Microsoft.AspNetCore.Identity;

namespace TourGuide.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        // Burası sonradan eklendi
        public string Description { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}

﻿using Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TourGuide.Application.Bases;
using TourGuide.Application.Interfaces.AutoMapper;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Auth.Commands.RevokeAll
{
    public class RevokeAllCommandHandler : BaseHandler, IRequestHandler<RevokeAllCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        public RevokeAllCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, UserManager<User> userManager) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
        }

        public async Task<Unit> Handle(RevokeAllCommandRequest request, CancellationToken cancellationToken)
        {
            List<User> users = await userManager.Users.ToListAsync(cancellationToken);

            foreach (User user in users)
            {
                user.RefreshToken = null;
                await userManager.UpdateAsync(user);
            }

            return Unit.Value;
        }
    }
}

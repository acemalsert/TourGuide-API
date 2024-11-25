using Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TourGuide.Application.Bases;
using TourGuide.Application.Features.Auth.Rules;
using TourGuide.Application.Interfaces.AutoMapper;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Auth.Commands.Revoke
{
    public class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly AuthRules authRules;

        public RevokeCommandHandler(UserManager<User> userManager, AuthRules authRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
            this.authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await userManager.FindByEmailAsync(request.Email);
            await authRules.EmailAddressShouldBeValid(user);

            user.RefreshToken = null;
            await userManager.UpdateAsync(user);

            return Unit.Value;
        }
    }
}

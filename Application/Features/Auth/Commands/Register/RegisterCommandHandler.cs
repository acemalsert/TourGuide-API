using Application.Interfaces.UnitOfWorks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using TourGuide.Application.Bases;
using TourGuide.Application.Features.Auth.Rules;
using TourGuide.Application.Interfaces.AutoMapper;
using TourGuide.Domain.Entities;

namespace TourGuide.Application.Features.Auth.Commands.Register
{
    public class RegisterCommandHandler : BaseHandler, IRequestHandler<RegisterCommandRequest, Unit>
    {
        private readonly AuthRules authRules;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;

        public RegisterCommandHandler(AuthRules authRules, UserManager<User> userManager, RoleManager<Role> roleManager, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.authRules = authRules;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<Unit> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            await authRules.UserShouldNotBeExist(await userManager.FindByEmailAsync(request.Email));

            // TODO : hatayı yukarıdaki gibi authrules gibi yönetmeliyiz. Hızlı olması açısından şimdilik bu satır eklendi
            if (!AllowedRoles.Roles.Contains(request.Role.ToLower()))
            {
                throw new ArgumentException($"Geçersiz rol: {request.Role}. Sadece şu roller kabul edilir: {string.Join(", ", AllowedRoles.Roles)}");
            }

            User user = mapper.Map<User, RegisterCommandRequest>(request);
            user.UserName = request.Email;
            user.SecurityStamp = Guid.NewGuid().ToString();

            IdentityResult result = await userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                if (!await roleManager.RoleExistsAsync(request.Role))
                    await roleManager.CreateAsync(new Role
                    {
                        Id = Guid.NewGuid(),
                        Name = request.Role,
                        NormalizedName = request.Role.ToUpper(),
                        ConcurrencyStamp = Guid.NewGuid().ToString(),
                    });

                await userManager.AddToRoleAsync(user, request.Role.ToLower());
            }

            return Unit.Value;
        }

        // TODO : bunu tasımalıyız!
        public static class AllowedRoles
        {
            public static readonly List<string> Roles = new List<string> { "user", "guide" };
        }
    }
}

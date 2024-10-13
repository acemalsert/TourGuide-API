using MediatR;
using TourGuide.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using TourGuide.Application.Features.Auth.Queries.GetGuideById;

namespace TourGuide.Application.Features.Auth.Queries.GetAllUsers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQueryRequest, GetGuideByIdQueryResponse>
    {
        private readonly UserManager<User> userManager;

        public GetGuideByIdQueryHandler(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<GetGuideByIdQueryResponse> Handle(GetGuideByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var guide = userManager.Users
                .Where(user => user.Id == request.Id)
                .SingleOrDefault();

            if (guide == null || !(await userManager.IsInRoleAsync(guide, "guide")))
            {
                // TODO : exception handling eklenmeli middleware üzerinden
                throw new Exception("Guide not found or user is not in the 'guide' role");
            }


            // TODO : burada mapper kullanılmalı
            // Gerekli olan diğer alanlar da sonradan eklenmeli queryresponse'a
            GetGuideByIdQueryResponse response = new GetGuideByIdQueryResponse
            {
                FullName = guide.FullName,
                Description = guide.Description,
            };

            return response;
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Identity;
using TourGuide.Application.Features.Auth.Queries.GetUserById;
using TourGuide.Domain.Entities;


namespace TourGuide.Application.Features.Auth.Queries.GetAllUsers
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQueryRequest, GetUserByIdQueryResponse>
    {
        private readonly UserManager<User> userManager;

        public GetUserByIdQueryHandler(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<GetUserByIdQueryResponse> Handle(GetUserByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var user = userManager.Users
                .Where(user => user.Id == request.Id)
                .SingleOrDefault();

            if (user == null)
            {
                // TODO : exception handling eklenmeli middleware üzerinden
                throw new Exception("User not found");
            }

            // TODO : burada mapper kullanılmalı
            // Gerekli olan diğer alanlar da sonradan eklenmeli queryresponse'a
            GetUserByIdQueryResponse response = new GetUserByIdQueryResponse
            {
                FullName = user.FullName,
                Description = user.Description,
            };

            return response;
        }
    }
}

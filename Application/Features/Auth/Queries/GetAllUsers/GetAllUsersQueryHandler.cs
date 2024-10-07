using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;
using TourGuide.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace TourGuide.Application.Features.Auth.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, IList<GetAllUsersQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<User> userManager;

        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllUsersQueryResponse>> Handle(GetAllUsersQueryRequest request, CancellationToken cancellationToken)
        {
            List<User> users = userManager.Users.ToList();

            List<GetAllUsersQueryResponse> response = new();

            // TODO : Buraya gerekli ise baska alanlar da eklenebilir
            foreach (var user in users)
            {
                response.Add(
                    new GetAllUsersQueryResponse()
                    {
                        FullName = user.FullName,
                        Description = user.Description,
                    });
            }

            return response;
        }
    }
}

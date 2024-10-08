using MediatR;
using Microsoft.AspNetCore.Identity;
using TourGuide.Application.Features.Auth.Queries.GetAllGuides;
using TourGuide.Application.Features.Auth.Queries.GetAllUsers;
using TourGuide.Domain.Entities;

public class GetAllGuidesQueryHandler : IRequestHandler<GetAllGuidesQueryRequest, IList<GetAllGuidesQueryResponse>>
{
    private readonly UserManager<User> userManager;

    public GetAllGuidesQueryHandler(UserManager<User> userManager)
    {
        this.userManager = userManager;
    }

    public async Task<IList<GetAllGuidesQueryResponse>> Handle(GetAllGuidesQueryRequest request, CancellationToken cancellationToken)
    {
        List<User> users = userManager.Users.ToList();

        List<GetAllGuidesQueryResponse> response = new();
       
        foreach (var user in users)
        {
            if (await userManager.IsInRoleAsync(user, "guide"))
            {
                response.Add(new GetAllGuidesQueryResponse()
                {
                    FullName = user.FullName,
                    Description = user.Description,
                });
            }
        }

        return response;
    }
}
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourGuide.Application.Features.Auth.Queries.GetGuideById;

namespace TourGuide.Application.Features.Auth.Queries.GetUserById
{
    public class GetUserByIdQueryRequest : IRequest<GetUserByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}

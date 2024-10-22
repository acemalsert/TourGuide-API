using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourGuide.Application.Features.Auth.Queries.GetUserById
{
    public class GetUserByIdQueryResponse
    {
        public Guid Id { get; set; }
        public string Email {  get; set; }
        public string FullName { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }

    }
}

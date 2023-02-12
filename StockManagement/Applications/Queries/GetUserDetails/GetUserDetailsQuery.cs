using MediatR;
using StockManagement.Models;

namespace StockManagement.Applications.Queries.GetUserDetails
{
    public class GetUserDetailsQuery : IRequest<List<Users>>
    {
        public bool? IsActive { get; set; }
    }
}

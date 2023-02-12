using MediatR;
using StockManagement.Models;
using StockManagement.Repositories;

namespace StockManagement.Applications.Queries.GetUserDetails
{
    public class GetUserDetailsHandler : IRequestHandler<GetUserDetailsQuery,List<Users>>
    {
        private readonly IUserRepository _userRepository;
        public GetUserDetailsHandler(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository ?? throw new ArgumentNullException();
        }

        public async Task<List<Users>> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserDetails(request.IsActive.Value);
        }
    }
}

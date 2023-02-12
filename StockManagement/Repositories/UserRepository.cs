using StockManagement.Models;

namespace StockManagement.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<Users>> GetUserDetails(bool IsActive)
        {
            var users = new List<Users>()
            {
            new Users() {Id=Guid.NewGuid(),FirstName="Parthiban",LastName="K",Email="kparthimsc@gmail.com",IsActive=true},
            new Users() {Id=Guid.NewGuid(),FirstName="Sreedevi",LastName="DV",Email="sreedevi.dv@gmail.com",IsActive=true},
            };
            return await Task.FromResult(users.Where(u=>u.IsActive==IsActive).ToList());
        }
    }
}

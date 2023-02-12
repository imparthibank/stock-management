using StockManagement.Models;

namespace StockManagement.Repositories
{
    public interface IUserRepository
    {
        Task<List<Users>> GetUserDetails(bool IsActive);
        
    }
}

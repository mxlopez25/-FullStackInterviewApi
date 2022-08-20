using WebService.Models;

namespace WebService.Interfaces {
    public interface IUserService {
        Task<List<Users>?> All();
        Task<Users?> Get(int Id);
        Task<Users?> Create(Users user);
        Task<Users?> Update(Users user);
        Task<bool?> Delete(int Id);
    }
}
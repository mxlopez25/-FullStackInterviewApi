using WebService.Models;
using WebService.Models.Entities;

namespace WebService.Services.Interfaces {
    public interface IUserService {
        Task<EUser?> All();
        Task<EUser?> Get(int Id);
        Task<EUser?> Create(Users user);
        Task<bool?> Update(Users user);
        Task<bool?> Delete(int Id);
    }
}
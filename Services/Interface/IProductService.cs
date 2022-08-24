using WebService.Models;
using WebService.Models.Entities;

namespace WebService.Services.Interfaces {
    public interface IProductService {
        Task<EProduct?> Get(int Id);
        Task<EProduct?> All();
        Task<EProduct?> Create(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(int Id);
    }
}
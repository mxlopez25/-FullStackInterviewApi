using WebService.Models;
using WebService.Models.Entities;

namespace WebService.Services.Interfaces {
    public interface IProductService {
        Task<EProduct?> Get(int Id);
        Task<EProduct?> All();
        Task<EProduct?> Create(Product product);
        Task<EProduct?> Update(Product product);
        Task<Boolean> Delete(int Id);
    }
}
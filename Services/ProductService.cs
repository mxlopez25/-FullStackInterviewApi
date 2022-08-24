using Microsoft.EntityFrameworkCore;
using WebService.Helpers;
using WebService.Models;
using WebService.Models.Entities;
using WebService.Services.Interfaces;

namespace WebService.Services {
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public async Task<EProduct?> All()
        {
            var products = await _dataContext.Products.ToListAsync();
            return new EProduct(products);
        }

        public async Task<EProduct?> Create(Product product)
        {
            _dataContext.Products.Add(product);
            await _dataContext.SaveChangesAsync();
            return new EProduct(product);
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<EProduct?> Get(int Id)
        {
            var product = await _dataContext.Products.FindAsync(Id);
            if(product != null) {
                return new EProduct(product);
            } else {
                return new EProduct();
            }
            
        }

        public async Task<bool> Update(Product product)
        {
            _dataContext.Entry(await _dataContext.Products.FirstOrDefaultAsync(x => x.Id == product.Id))
            .CurrentValues.SetValues(product);
            return await _dataContext.SaveChangesAsync() > 0; 
        }
    }
}
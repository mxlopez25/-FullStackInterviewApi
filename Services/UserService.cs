using Microsoft.EntityFrameworkCore;
using WebService.Helpers;
using WebService.Interfaces;
using WebService.Models;
using WebService.Models.Entities;

namespace WebService.Services {
    public class UserService: IUserService {

        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public async Task<EUser?> All()
        {
            var users = await _dataContext.Users.ToListAsync();            
            return (users != null) ? new EUser(users) : null;
        }

        public async Task<EUser?> Create(Users user)
        {
            user.CreatedDate = DateTime.Now;
            user.Status = UserStatus.Active;
            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();
            
            return new EUser(user);
        }

        public Task<bool?> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<EUser?> Get(int Id)
        {
            var user = await _dataContext.Users.FindAsync(Id);
            return (user != null) ? new EUser(user) : null;
        }

        public async Task<EUser?> Update(Users user)
        {
            var u = await _dataContext.Users.FindAsync(user.Id);
            if (u != null) {
                return new EUser(u);
            } else {
                return new EUser(user);
            }
        }
    }
}
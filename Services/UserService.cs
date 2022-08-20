using Microsoft.EntityFrameworkCore;
using WebService.Helpers;
using WebService.Interfaces;
using WebService.Models;

namespace WebService.Services {
    public class UserService: IUserService {

        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext) {
            _dataContext = dataContext;
        }

        public async Task<List<Users>?> All()
        {
            var users = await _dataContext.Users.ToListAsync();
            return (users != null) ? users : null;
        }

        public async Task<Users?> Create(Users user)
        {
            user.CreatedDate = DateTime.Now;
            user.Status = UserStatus.Active;
            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            return user;
        }

        public Task<bool?> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Users?> Get(int Id)
        {
            var user = await _dataContext.Users.FindAsync(Id);
            return (user != null) ? user : null;
        }

        public async Task<Users?> Update(Users user)
        {
            var u = await _dataContext.Users.FindAsync(user.Id);
            if (u != null) {
                return u;
            } else {
                return user;
            }
        }
    }
}
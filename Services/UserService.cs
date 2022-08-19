using WebService.Interfaces;
using WebService.Models;

namespace WebService.Services {
    public class UserService: IUserService {
        public UserService() {

        }

        public Task<List<Users>> All()
        {
            throw new NotImplementedException();
        }

        public Task<Users> Create(Users user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Users> Update(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
using Promolt.Core.DB_Accessors;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;

namespace Promolt.Core
{
    public class UserServices : IUserServices
    {
        private readonly IDBUsersAccessor _usersAccessor;
        public UserServices(IDBUsersAccessor dBUsersAccessor)
        {
            _usersAccessor=dBUsersAccessor;
        }

        public async Task CreateUser(UserModel user)
        {
           await _usersAccessor.CreateUser(user);
        }

        public async Task DeleteUser(string id)
        {
            await _usersAccessor.DeleteUser(id);
        }

        public async Task<UserModel> GetUser(string id)
        {
           var user = await _usersAccessor.GetUser(id);
            return user;
        }
        public async Task<UserModel> GetUserByEmail(LoginModel login)
        {
            var user = await _usersAccessor.GetUserByEmail(login);
            return user;
        }

        public Task<List<UserModel>> GetUsers()
        {
            var users = _usersAccessor.GetUsers();
            return users;
        }

        public async Task UpdateUser(string id, UserModel updatedUser)
        {
           await _usersAccessor.UpdateUser(id,updatedUser);
        }
    }
}
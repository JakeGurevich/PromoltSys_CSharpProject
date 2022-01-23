using Client.Interfaces;
using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public class UsersServices:IUsersServices
    {
        private readonly IUsersClient _usersClient;

        public UsersServices()
        {
            _usersClient = RestService.For<IUsersClient>("https://localhost:7125/");
        }

        public async Task CreateUser(UserModel user)
        {
            await _usersClient.CreateUser(user);
        }

        public async Task DeleteUser(string id)
        {
            await _usersClient.DeleteUser(id);
        }

        public async Task<UserModel> GetUser(string id)
        {
            var user = await _usersClient.GetUser(id);
            return user;
        }

        public Task<List<UserModel>> GetUsers()
        {
            var users = _usersClient.GetUsers();
            return users;
        }

        public async Task UpdateUser(string id, UserModel updatedUser)
        {
            await _usersClient.UpdateUser(id, updatedUser);
        }
    }
}

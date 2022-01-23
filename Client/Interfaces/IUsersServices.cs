using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IUsersServices
    {
        Task CreateUser(UserModel user);
        Task DeleteUser(string id);
        Task<UserModel> GetUser(string id);
        Task<List<UserModel>> GetUsers();
        Task UpdateUser(string id, UserModel updatedUser);
    }
}

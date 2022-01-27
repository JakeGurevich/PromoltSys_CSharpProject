using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Interfaces
{
    public interface IUserServices
    {
        Task CreateUser(UserModel user);
        Task DeleteUser(string id);
        Task<UserModel> GetUser(string id);
        Task<UserModel> GetUserByEmail(LoginModel login);
        Task<List<UserModel>> GetUsers();
        Task UpdateUser(string id, UserModel updatedUser);
    }
}

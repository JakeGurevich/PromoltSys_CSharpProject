using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Models;
using Refit;

namespace Client.Interfaces
{
    public interface IUsersClient
    {
        [Post("/api/users")]
        Task CreateUser([Body]UserModel user);
        [Delete("/api/users/{id}")]
        Task DeleteUser(string id);
        [Get("/api/users/{id}")]
        Task<UserModel> GetUser(string id);
        [Get("/api/users")]
        Task<List<UserModel>> GetUsers();
        [Put("/api/users/{id}")]
        Task UpdateUser(string id, [Body]UserModel updatedUser);
    }
}

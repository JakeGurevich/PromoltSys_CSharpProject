using Promolt.Core.Models;

namespace Promolt.Core.DB_Accessors
{
    public interface IDBUsersAccessor
    {
        Task CreateUser(UserModel user);
        Task DeleteUser(string id);
        Task<UserModel> GetUser(string id);
        Task<UserModel> GetUserByEmail(LoginModel login);
        Task<List<UserModel>> GetUsers();
        Task UpdateUser(string id, UserModel updatedUser);
    }
}
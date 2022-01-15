using Promolt.Core.Interfaces;
using Promolt.Core.Models;

namespace Promolt.Core
{
    public class UserServices : IUserServices
    {
        public List<UserModel> GetUsers()
        {
            return new List<UserModel> { new UserModel() { FirstName="Yakov",LastName="Gurevich",Email="mail@gmail.com"} };
        }
    }
}
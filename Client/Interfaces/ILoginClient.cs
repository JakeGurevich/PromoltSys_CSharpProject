using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface ILoginClient
    {

        [Post("/api/login")]
        Task<UserModel> Login([Body] LoginModel login);
    }
}

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
    public class LoginServices : ILoginServices
    {


        private readonly ILoginClient _loginClient;
        public LoginServices()
        {
            _loginClient = RestService.For<ILoginClient>("https://localhost:7125/");
        }
        public async Task<UserModel> Login([Body] LoginModel login)
        {
            var user = await _loginClient.Login(login);
            return user;
        }
    }
}

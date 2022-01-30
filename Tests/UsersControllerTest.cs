using Microsoft.AspNetCore.Mvc;
using Moq;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;
using Server.Controllers;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class UsersControllerTests
    {
        private readonly Mock< IUserServices> servicesStub = new Mock<IUserServices>();

        [Fact]
        public async Task GetUserAsync_WithExistingUser_ExpectedBehavior()
        {
            var expectedUser= CreateRandomUser();
            servicesStub.Setup(service=>service.GetUser(It.IsAny<string> ()))
                .ReturnsAsync (expectedUser);

            var controller = new UsersController(servicesStub.Object);
           var  result = await controller.Get(Guid.NewGuid().ToString());

            Assert.IsType<UserModel>(result.Value);
            var user = (result as ActionResult<UserModel>) .Value;
            Assert.Equal(expectedUser.Id, user.Id);
            Assert.Equal(expectedUser.FirstName, user.FirstName);
            Assert.Equal(expectedUser.LastName, user.LastName);
            Assert.Equal(expectedUser.Email, user.Email);
            Assert.Equal(expectedUser.Password, user.Password);


        }

        private UserModel CreateRandomUser()
        {
            return new()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = Guid.NewGuid().ToString(),
                LastName = Guid.NewGuid().ToString(),
                Email = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
                Role = "user"
            };
        }
    }
}
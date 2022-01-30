using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IOrderServices
    {

        Task CreateOrder(OrderModel order);
        Task<OrderModel> GetOrder(string id);
        Task<List<OrderModel>> GetOrders();
        Task<List<OrderModel>> GetOrders(string id);
        Task<OrderModel> MakeOrder(UserModel user, int qty, DonationModel donation);


    }
}

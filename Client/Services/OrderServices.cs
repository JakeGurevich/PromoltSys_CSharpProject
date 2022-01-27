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
    public class OrderServices:IOrderServices
    {
        private readonly IOrderClient _orderClient;
        public OrderServices()
        {
            _orderClient = RestService.For<IOrderClient>("https://localhost:7125/");
        }

        public async Task CreateOrder(OrderModel order)
        {
            await _orderClient.CreateOrder(order);
        }


        public async Task<OrderModel> GetOrder(string id)
        {
            var order = await _orderClient.GetOrder(id);
            return order;
        }

        public Task<List<OrderModel>> GetOrders()
        {
            var orders = _orderClient.GetOrders();
            return orders;
        }
    }
}

using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IOrderClient
    {

        [Post("/api/orders")]
        Task CreateOrder([Body] OrderModel order);


        [Get("/api/orders/{id}")]
        Task<OrderModel> GetOrder(string id);
        [Get("/api/orders")]
        Task<List<OrderModel>> GetOrders();
        [Get("/api/orders/filter/{id}")]
        Task<List<OrderModel>> GetOrders(string id);
    }
}

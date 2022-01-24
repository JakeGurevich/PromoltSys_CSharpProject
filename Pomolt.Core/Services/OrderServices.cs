using Promolt.Core.Interfaces;
using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Services
{
    public class OrderServices:IOrderServices
    {

        private readonly IDBOrderAccessor _ordersAccessor;
        public OrderServices(IDBOrderAccessor dBOrderAccessor)
        {
            _ordersAccessor = dBOrderAccessor;
        }

        public async Task CreateOrder(OrderModel order)
        {
            await _ordersAccessor.CreateOrder(order);
        }

        public async Task<OrderModel> GetOrder(string id)
        {
            var order = await _ordersAccessor.GetOrder(id);
            return order;
        }

        public async Task<List<OrderModel>> GetOrders()
        {
            var orders = await _ordersAccessor.GetOrders();
            return orders;
        }
    }
}

using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Interfaces
{
    public interface IDBOrderAccessor
    {

        Task CreateOrder(OrderModel order);
        Task<OrderModel> GetOrder(string id);
        Task<List<OrderModel>> GetOrders();
    }
}

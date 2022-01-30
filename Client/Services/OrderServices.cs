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

        public async Task<List<OrderModel>> GetOrders()
        {
            var orders =await _orderClient.GetOrders();
            return orders;
        }

        public async Task<List<OrderModel>> GetOrders(string id)
        {
            var orders = await _orderClient.GetOrders(id);
            return orders;
        }
       
        public async Task<OrderModel> MakeOrder(UserModel user, int qty, DonationModel donation)
        {
            var item = new ItemModel { Title = donation.ProductName, Qty = qty, 
                Price = (decimal)donation.Price };
            var cart = new List<ItemModel>();
            cart.Add(item);
            var order = new OrderModel { Cart = cart, TotalPrice = item.Price * item.Qty, 
                CreatedBy = user.Id,DonatedBy=donation.DonatedBy, CreatedAt = DateTime.Now };
            await CreateOrder(order);
            return order;


        }
    }
}

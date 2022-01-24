using MongoDB.Driver;
using Promolt.Core.Interfaces;
using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.DB_Accessors
{
    public class MongoDBOrderAccessor:IDBOrderAccessor
    {


        private const string DB_NAME = "promotitdb";
        private const string COLLECTION_NAME = "orders";
        private readonly IMongoCollection<OrderModel> ordersCollection;


        public MongoDBOrderAccessor(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(DB_NAME);
            ordersCollection = database.GetCollection<OrderModel>(COLLECTION_NAME);
        }


        public async Task<OrderModel> GetOrder(string id)
        {
            var order = await ordersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return order;
        }

        public async Task<List<OrderModel>> GetOrders()
        {
            return await ordersCollection.Find(order => true).ToListAsync();
        }
        public async Task CreateOrder(OrderModel order)
        {
            await ordersCollection.InsertOneAsync(order);

        }
    }
}

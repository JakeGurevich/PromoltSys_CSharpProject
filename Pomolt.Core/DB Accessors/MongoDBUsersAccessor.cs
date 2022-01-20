using MongoDB.Bson;
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
    public class MongoDBUsersAccessor : IDBUsersAccessor
    {
        private const string DB_NAME = "promotitdb";
        private const string COLLECTION_NAME = "users";
        private readonly IMongoCollection<UserModel> usersCollection;


        public MongoDBUsersAccessor(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(DB_NAME);
            usersCollection = database.GetCollection<UserModel>(COLLECTION_NAME);
        }


        public async Task<UserModel> GetUser(string id)
        {
            var user = await usersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<UserModel>> GetUsers()
        {
            return await usersCollection.Find(user => true).ToListAsync();
        }
        public async Task CreateUser(UserModel user)
        {
            await usersCollection.InsertOneAsync(user);

        }


        public async Task UpdateUser(string id, UserModel updatedUser) =>
            await usersCollection.ReplaceOneAsync(x => x.Id == id, updatedUser);

        public async Task DeleteUser(string id)
        {
            await usersCollection.DeleteOneAsync(x => x.Id == id);
        }

    }
}


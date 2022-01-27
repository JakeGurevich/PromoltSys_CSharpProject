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
    public class MongoDBDonationAccessor:IDBDonationAccessor
    {

        private const string DB_NAME = "promotitdb";
        private const string COLLECTION_NAME = "donations";
        private readonly IMongoCollection<DonationModel> donationsCollection;


        public MongoDBDonationAccessor(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(DB_NAME);
            donationsCollection = database.GetCollection<DonationModel>(COLLECTION_NAME);
        }


        public async Task<DonationModel> GetDonation(string id)
        {
            var donation = await donationsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return donation;
        }

        public async Task<List<DonationModel>> GetDonations()
        {
            return await donationsCollection.Find(donation => true).ToListAsync();
        }
        public async Task CreateDonation(DonationModel donation)
        {
            await donationsCollection.InsertOneAsync(donation);

        }
        public async Task UpdateDonation(string id, DonationModel updatedDonation)
        {
            await donationsCollection.ReplaceOneAsync(x => x.Id == id, updatedDonation);
        }
    }
}

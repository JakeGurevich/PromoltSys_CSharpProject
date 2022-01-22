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
    public class MongoDBCampaignsAccessor:IDBCampaignsAccessor
    {
        private const string DB_NAME = "promotitdb";
        private const string COLLECTION_NAME = "campaigns";
        private readonly IMongoCollection<CampaignModel> campaignsCollection;


        public MongoDBCampaignsAccessor(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(DB_NAME);
            campaignsCollection = database.GetCollection<CampaignModel>(COLLECTION_NAME);
        }


        public async Task<CampaignModel> GetCampaign(string id)
        {
            var campaign = await campaignsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
            return campaign;
        }

        public async Task<List<CampaignModel>> GetCampaigns()
        {
            return await campaignsCollection.Find(campaign => true).ToListAsync();
        }
        public async Task CreateCampaign(CampaignModel campaign)
        {
            await campaignsCollection.InsertOneAsync(campaign);

        }


        public async Task UpdateCampaign(string id, CampaignModel updatedCampaign) =>
            await campaignsCollection.ReplaceOneAsync(x => x.Id == id, updatedCampaign);

        public async Task DeleteCampaign(string id)
        {
            await campaignsCollection.DeleteOneAsync(x => x.Id == id);
        }
    }
}

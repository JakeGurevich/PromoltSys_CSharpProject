using Promolt.Core.Interfaces;
using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Services
{
    public class CampaignServices:ICampaignServices
    {
        private readonly IDBCampaignsAccessor _campaignsAccessor;
        public CampaignServices(IDBCampaignsAccessor dBCampaignsAccessor)
        {
            _campaignsAccessor = dBCampaignsAccessor;
        }

        public async Task CreateCampaign(CampaignModel campaign)
        {
            await _campaignsAccessor.CreateCampaign(campaign);
        }

        public async Task DeleteCampaign(string id)
        {
            await _campaignsAccessor.DeleteCampaign(id);
        }

        public async Task<CampaignModel> GetCampaign(string id)
        {
            var campaign = await _campaignsAccessor.GetCampaign(id);
            return campaign;
        }

        public Task<List<CampaignModel>> GetCampaigns()
        {
            var campaigns = _campaignsAccessor.GetCampaigns();
            return campaigns;
        }

        public async Task UpdateCampaign(string id, CampaignModel updatedCampaign)
        {
            await _campaignsAccessor.UpdateCampaign(id, updatedCampaign);
        }
    }
}

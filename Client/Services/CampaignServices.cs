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
    public class CampaignServices:ICampaignServices
    {
        private readonly ICampaignClient _campaignClient;
        public CampaignServices()
        {
            _campaignClient = RestService.For<ICampaignClient>("https://localhost:7125/");
        }

        public async Task CreateCampaign(CampaignModel campaign)
        {
            await _campaignClient.CreateCampaign(campaign);
        }

        public async Task DeleteCampaign(string id)
        {
            await _campaignClient.DeleteCampaign(id);
        }

        public async Task<CampaignModel> GetCampaign(string id)
        {
            var campaign = await _campaignClient.GetCampaign(id);
            return campaign;
        }

        public Task<List<CampaignModel>> GetCampaigns()
        {
            var campaigns = _campaignClient.GetCampaigns();
            return campaigns;
        }

        public async Task UpdateCampaign(string id, CampaignModel updatedCampaign)
        {
            await _campaignClient.UpdateCampaign(id, updatedCampaign);
        }
    }
}

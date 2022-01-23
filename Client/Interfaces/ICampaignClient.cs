
using Client.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface ICampaignClient
    {
        [Post("/api/campaigns")]
        Task CreateCampaign([Body]CampaignModel campaign);
        
       [Delete("/api/campaigns/{id}")]
        Task DeleteCampaign(string id);
        [Get("/api/campaigns/{id}")]
        Task<CampaignModel> GetCampaign(string id);
        [Get("/api/campaigns")]
        Task<List<CampaignModel>> GetCampaigns();
        [Put("/api/users/{id}")]
        Task UpdateCampaign(string id,[Body] CampaignModel updatedCampaign);
    }
}

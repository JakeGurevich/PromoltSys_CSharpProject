using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Interfaces
{
    public interface IDBCampaignsAccessor
    {
        Task CreateCampaign(CampaignModel campaign);
        Task DeleteCampaign(string id);
        Task<CampaignModel> GetCampaign(string id);
        Task<List<CampaignModel>> GetCampaigns();
        Task UpdateCampaign(string id, CampaignModel updatedCampaign);
    }
}

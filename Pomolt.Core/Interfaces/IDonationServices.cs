using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Interfaces
{
    public interface IDonationServices
    {
        Task CreateDonation(DonationModel campaign);
        Task<DonationModel> GetDonation(string id);
        Task<List<DonationModel>> GetDonations();
    }
}

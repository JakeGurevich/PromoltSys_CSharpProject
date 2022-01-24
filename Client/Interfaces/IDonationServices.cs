using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Interfaces
{
    public interface IDonationServices
    {
        Task CreateDonation(DonationModel Donation);
        
        Task<DonationModel> GetDonation(string id);
        Task<List<DonationModel>> GetDonations();
    }
}

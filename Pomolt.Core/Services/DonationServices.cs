using Promolt.Core.Interfaces;
using Promolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promolt.Core.Services
{
    public class DonationServices : IDonationServices

    {



        private readonly IDBDonationAccessor _donationsAccessor;
        public DonationServices(IDBDonationAccessor dBDonationsAccessor)
        {
            _donationsAccessor = dBDonationsAccessor;
        }
       
        public async Task CreateDonation(DonationModel donation)
        {
            await _donationsAccessor.CreateDonation(donation);
        }

        public async Task<DonationModel> GetDonation(string id)
        {
            var donation = await _donationsAccessor.GetDonation(id);
            return donation;
        }

        public Task<List<DonationModel>> GetDonations()
        {
            var donations = _donationsAccessor.GetDonations();
            return donations;
        }
        public async Task UpdateDonation(string id, DonationModel updatedDonation)
        {
           
                await _donationsAccessor.UpdateDonation(id, updatedDonation);
            
        }
    }
}

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
    public class DonationServices:IDonationServices
    {


        private readonly IDonationClient _donationClient;
        public DonationServices()
        {
            _donationClient = RestService.For<IDonationClient>("https://localhost:7125/");
        }

        public async Task CreateDonation(DonationModel donation)
        {
            await _donationClient.CreateDonation(donation);
        }

      
        public async Task<DonationModel> GetDonation(string id)
        {
            var donation = await _donationClient.GetDonation(id);
            return donation;
        }

        public Task<List<DonationModel>> GetDonations()
        {
            var donations = _donationClient.GetDonations();
            return donations;
        }

    }
}

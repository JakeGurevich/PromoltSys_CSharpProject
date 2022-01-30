using Client.Interfaces;
using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class AdminProfile : Form
    {
        private readonly ILoginServices _loginServices;
        private readonly ISocialServices _socialServices;
        private readonly ICampaignServices _campaignServices;
        private readonly IDonationServices _donationServices;
        private readonly IOrderServices _orderServices;
        private readonly IUsersServices _usersServices;
        private UserModel _user;
        public AdminProfile(ILoginServices loginServices, ISocialServices socialServices,
            ICampaignServices campaignServices, IDonationServices donationServices,
            IOrderServices orderServices, IUsersServices usersServices, UserModel user)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _socialServices = socialServices;
            _campaignServices = campaignServices;
            _donationServices = donationServices;
            _orderServices = orderServices;
            _usersServices = usersServices;
            _user = user;
            label_Name.Text = _user.FirstName + " " + _user.LastName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private async void btn_GetCampaigns_Click(object sender, EventArgs e)
        {
            var campaigns = await _campaignServices.GetCampaigns();
            l_Campaigns.Text = campaigns.Count.ToString();
            dg_Campaigns.DataSource = campaigns;
        }

        private async void btn_GetDonations_Click(object sender, EventArgs e)
        {
            var donations=await _donationServices.GetDonations();
            l_Donations.Text = donations.Count.ToString();
            dg_Donations.DataSource = donations;
        }
    }
}

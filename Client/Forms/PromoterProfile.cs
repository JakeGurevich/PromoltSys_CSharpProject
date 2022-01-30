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
using Tweetinvi.Models;

namespace Client.Forms
{
    public partial class PromoterProfile : Form
    {
        private readonly ILoginServices _loginServices;
        private readonly ISocialServices _socialServices;
        private readonly ICampaignServices _campaignServices;
        private readonly IDonationServices _donationServices;
        private readonly IOrderServices _orderServices;
        private readonly IUsersServices _usersServices;
        private UserModel _user;
        private List<ITweet> tweets = new List<ITweet>();
        private List<CampaignModel> campaigns = new List<CampaignModel>();
        public PromoterProfile(ILoginServices loginServices, ISocialServices socialServices,
            ICampaignServices campaignServices, IDonationServices donationServices,
            IOrderServices orderServices, IUsersServices usersServices,UserModel user)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _socialServices = socialServices;
            _campaignServices = campaignServices;
            _donationServices = donationServices;
            _orderServices = orderServices;
            _usersServices = usersServices;
            _user = user;
            label_Name.Text=_user.FirstName+" "+_user.LastName;

        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (_user.Account != null)
                {
                    var Tweets = await _socialServices.GetTweets(_user.Account.SocialUserName);

                    dg_Tweets.DataSource = Tweets;
                }
                campaigns = await _campaignServices.GetCampaigns();

                _user.Account!.Cash = _socialServices.InitCash(InitHashtagsList());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

     

       
      

       
        private List<string> InitHashtagsList()
        {
            List<string> allCampaignHashtags = new List<string>();
            foreach (var campaign in campaigns)
            {
                //if (campaign.Hashtag.StartsWith("#"))
                //{
                //    campaign.Hashtag = campaign.Hashtag.Substring(1);
                //}
                if (!allCampaignHashtags.Contains(campaign.Hashtag))
                {
                    allCampaignHashtags.Add(campaign.Hashtag.Substring(1));
                }
            }
            return allCampaignHashtags;
        }

       

       

       

      

        private async void btn_GetCampaigns_Click_1(object sender, EventArgs e)
        {
            campaigns = await _campaignServices.GetCampaigns();
            dg_Campaigns.DataSource = campaigns;
            dg_Campaigns.Columns["id"].Visible = false;
        }

        private async void btn_ConnectToTwiter_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (_user != null)
                {
                    var Tweets = await _socialServices.GetTweets(_user.Account.SocialUserName);

                    dg_Tweets.DataSource = Tweets;
                    dg_Tweets.Columns["Client"].Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Post_Click_1(object sender, EventArgs e)
        {
            _socialServices.PostTweet(txt_Tweet.Text);
        }

        private async void btn_Buy_Click_1(object sender, EventArgs e)
        {
            try
            {
                var product = await _donationServices.GetDonation(txt_PoductId.Text);
                if (_user.Account.Cash >= product.Price )
                {
                    var order = await _orderServices.MakeOrder(_user, 1, product);

                    _user.Account.TotalCashSpend += order.TotalPrice;
                    await _usersServices.UpdateUser(_user.Id, _user);
                    product.Qty -= 1;
                    await _donationServices.UpdateDonation(product.Id, product);
                    MessageBox.Show("Order created");
                }
                else
                {
                    throw new Exception("Not enouph cash");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GetBalance_Click(object sender, EventArgs e)
        {
            try
            {
                _socialServices.UpdateHashtasFromTweets(_user?.Account?.SocialUserName!);
                _user.Account.Cash = _socialServices.InitCash(InitHashtagsList()) - _user.Account.TotalCashSpend;
                label_Balance.Text = _user.Account.Cash.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private async void btn_GetDonations_Click_1(object sender, EventArgs e)
        {
            var products = await _donationServices.GetDonations();
            dg_Products.DataSource = products;
            dg_Products.Columns["id"].Visible = false;
        }

        private void dg_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedProduct = dg_Products.SelectedRows[0].DataBoundItem as DonationModel;
            txt_ProductName.Text = selectedProduct!.ProductName;
            txt_Price.Text = selectedProduct!.Price.ToString();
            txt_PoductId.Text = selectedProduct.Id;
        }

        private void txt_Tweet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dg_Campaigns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCampaign = dg_Campaigns.SelectedRows[0].DataBoundItem as CampaignModel;
            txt_CampaignName.Text = selectedCampaign!.Title;
            txt_Tweet.Text = selectedCampaign.Hashtag;

        }

        private async void PromoterProfile_Load(object sender, EventArgs e)
        {
            
            try
            {
                campaigns = await _campaignServices.GetCampaigns();
                if (_user != null)
                {
                    var Tweets = await _socialServices.GetTweets(_user.Account.SocialUserName);

                    dg_Tweets.DataSource = Tweets;
                    dg_Tweets.Columns["Client"].Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    

        private void btn_ConnectToTwitter_Click(object sender, EventArgs e)
        {
            _socialServices.ConnectToTwitter();
        }
    }
}

using Client.Interfaces;
using Client.Models;
using Client.Services;
using System.Linq;
using Tweetinvi.Models;

namespace PromoterClient
{
    public partial class Form1 : Form
    {
        private readonly ILoginServices _loginServices;
        private readonly ISocialServices _socialServices;
        private readonly ICampaignServices _campaignServices;
        private readonly IDonationServices _donationServices;
        private readonly IOrderServices _orderServices;
        private readonly IUsersServices _usersServices;
        private UserModel _user;
        private  List<ITweet> tweets=new List<ITweet>();
        private List<CampaignModel> campaigns=new List<CampaignModel>();
        public Form1(ILoginServices loginServices,ISocialServices socialServices, 
            ICampaignServices campaignServices, IDonationServices donationServices,
            IOrderServices orderServices, IUsersServices usersServices)
        {
            InitializeComponent();
            _loginServices = loginServices;
            _socialServices = socialServices;
            _campaignServices= campaignServices;
            _donationServices= donationServices;
            _orderServices= orderServices;
            _usersServices= usersServices;
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                var login = new LoginModel { Password = txt_Pass.Text, Email = txt_Email.Text };
                 _user = await _loginServices.Login(login);
                txt_UserId.Text = _user.Id;
                if (_user.Account != null)
                {
                    var Tweets = await _socialServices.GetTweets(_user.Account.SocialUserName);

                    dg_Tweets.DataSource = Tweets;
                }
                campaigns = await _campaignServices.GetCampaigns();
              
                _user.Account.Cash = _socialServices.InitCash(InitHashtagsList());
            }
            catch (Exception ex)
            {

              MessageBox.Show(ex.Message);  
            }
          
        }

        private async void btn_ConnectToTwiter_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user != null)
                {
                    var Tweets = await _socialServices.GetTweets(_user.Account.SocialUserName);

                    dg_Tweets.DataSource = Tweets;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void txt_twiterUser_TextChanged(object sender, EventArgs e)
        {

        }

        private  void btn_Post_Click(object sender, EventArgs e)
        {
            _socialServices.PostTweet(txt_Tweet.Text);
        }

        private async void btn_GetCampaigns_Click(object sender, EventArgs e)
        {
            campaigns=await _campaignServices.GetCampaigns();
            dg_Campaigns.DataSource = campaigns;
        }
        private List<string> InitHashtagsList()
        {
            List<string> allCampaignHashtags = new List<string>();
            foreach (var campaign in campaigns)
            {
                if (campaign.Hashtag.StartsWith("#"))
                {
                    campaign.Hashtag=campaign.Hashtag.Substring(1);
                }
                if(!allCampaignHashtags.Contains(campaign.Hashtag)){
                       allCampaignHashtags.Add(campaign.Hashtag);
                }
            }
            return allCampaignHashtags;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user.Account.Cash = _socialServices.InitCash(InitHashtagsList())-_user.Account.TotalCashSpend;
            txt_Balance.Text = _user.Account.Cash.ToString();
        }

        private async void btn_GetDonations_Click(object sender, EventArgs e)
        {
            var products=await _donationServices.GetDonations();
            dg_Products.DataSource= products;
        }

        private async void btn_Buy_Click(object sender, EventArgs e)
        {

            try
            {
                var product = await _donationServices.GetDonation(txt_ProductId.Text);

                if (_user.Account.Cash >= product.Price * 1)
                {
                   var order= await _socialServices.MakeOrder(_user, 1, product, _orderServices);
                 
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
    }
}
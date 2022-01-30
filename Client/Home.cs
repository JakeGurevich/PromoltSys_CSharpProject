using Client.Forms;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using Promolt.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Home : Form
    {
       private Form UserForm;
        private Form PromoterForm;
        private Form AdminProfileForm;
        private Form PromoterProfileForm;
        private Form SponsorProfileForm;
        private Form UserProfileForm;
       private ILoginServices _loginServices;
        private UserModel _user;
        public Home(ILoginServices loginServices)
        {
            InitializeComponent();
            _loginServices = loginServices; 
        }


        private async void btn_Login_Click(object sender, EventArgs e)
        {
            var loginObj=new LoginModel() { Email = txt_email.Text, Password = txt_Pass.Text };
             _user = await _loginServices.Login(loginObj);
            if (_user.Role == "admin")
            {
                AdminProfileForm = new AdminProfile(new LoginServices(), new SocialServices(),
            new CampaignServices(), new DonationServices(),
           new OrderServices(), new UsersServices(), _user);
                AdminProfileForm.Show();
            }else if(_user.Role == "promoter")
            {
                PromoterProfileForm = new PromoterProfile(new LoginServices(), new SocialServices(),
            new CampaignServices(), new DonationServices(),
           new OrderServices(), new UsersServices(), _user);
                PromoterProfileForm.Show();
            }else if(_user.Role=="sponsor")
            {
                SponsorProfileForm = new SponsorProfile(
        new DonationServices(),
      new OrderServices() , _user);
                SponsorProfileForm.Show();
            }else
            {

                UserProfileForm = new UserProfile(new CampaignServices(), _user);
                UserProfileForm.Show();
            }
          
           // this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserForm = new CreateUser(new UsersServices(),"user");
            UserForm.Show();
        }

        private void btn_CreateSponsor_Click(object sender, EventArgs e)
        {
            UserForm = new CreateUser(new UsersServices(), "sponsor");
            UserForm.Show();
        }

        private void btn_CreatePromoter_Click(object sender, EventArgs e)
        {
            PromoterForm = new CreatePromoter(new UsersServices());
            PromoterForm.Show();
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

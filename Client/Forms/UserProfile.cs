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
    public partial class UserProfile : Form
    {
        ICampaignServices _campaignServices;
        UserModel _user;
        public UserProfile(ICampaignServices campaignServices,UserModel user)
        {
            InitializeComponent();
            _campaignServices = campaignServices;  
            _user = user;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newCampaign = new CampaignModel()
                {
                    Title = txt_Title.Text,
                    Hashtag = txt_Hashtag.Text,
                    Url = txt_Url.Text,
                    CreatedBy = _user.Id!
                };
                await _campaignServices.CreateCampaign(newCampaign);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private async void btn_GetCampaigns_Click(object sender, EventArgs e)
        {
            dg_Campains.DataSource=await _campaignServices.GetCampaigns();
            dg_Campains.Columns["id"].Visible=false;
         
        }

        private void dg_Campains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCampaign = dg_Campains.SelectedRows[0].DataBoundItem as CampaignModel;
        }
    }
}

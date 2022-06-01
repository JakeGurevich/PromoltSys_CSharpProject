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
    public partial class SponsorProfile : Form
    {
        private UserModel _user;
        private readonly IDonationServices _donationServices;
        private readonly IOrderServices _orderServices;
        public SponsorProfile(IDonationServices donationServices,
            IOrderServices orderServices,UserModel user)
        {
            InitializeComponent();
            _donationServices = donationServices;
            _orderServices = orderServices;
            _user = user;
            label_Name.Text = _user.FirstName + " " + _user.LastName;
        }

        private void SponsorProfile_Load(object sender, EventArgs e)
        {

        }

        private async void btn_GetOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var orders = await _orderServices.GetOrders(_user.Id);
                dg_Orders.DataSource= orders;
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btn_DonateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var newDonation = new DonationModel()
                {
                    ProductName = txt_Name.Text,
                    Qty = int.Parse(txt_Qty.Text),
                    Price = decimal.Parse(txt_Price.Text),
                    DonatedBy=_user.Id,
                    CreatedAt = DateTime.Now,



                };
                await _donationServices.CreateDonation(newDonation);
                MessageBox.Show("Thank you for donation!");
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
            
        }

        private async void btn_GetDonationss_Click(object sender, EventArgs e)
        {
            dg_Campaigns.DataSource = await _donationServices.GetDonations(_user.Id);
            dg_Campaigns.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Shipped.Thank you!");
        }

        private void dg_Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedOrder = dg_Orders.SelectedRows[0].DataBoundItem as OrderModel;
            txt_OrderProductName.Text = selectedOrder!.Cart[0].Title;
            txt_OrderPrice.Text = selectedOrder!.TotalPrice.ToString();
        }
    }
}

using Client.Interfaces;
using Client.Models;
using Client.Services;
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
    public partial class CreatePromoter : Form
    {
        public IUsersServices _usersServices;
        public CreatePromoter(IUsersServices usersServices)
        {
            InitializeComponent();
            _usersServices = usersServices;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_CreatePromoter_Click(object sender, EventArgs e)
        {
            try
            {

                var user = new UserModel
                {
                    FirstName = txt_First.Text,
                    LastName = txt_Last.Text,
                    Password = txt_Pass.Text,
                    Email = txt_email.Text,
                    Role = "promoter",
                    Account=new AccountModel() { SocialUserName=txt_TweeterUserName.Text}
                   
                };
                await _usersServices.CreateUser(user);
                MessageBox.Show("User created :) Now you can Sign In  ");
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

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

namespace Client
{
    public partial class CreateUser : Form
    {
        public IUsersServices _usersServices;
        private string _type;
        public CreateUser(IUsersServices usersServices,string type)
        {
            InitializeComponent();
            _usersServices = usersServices;
            _type = type;
        }

        private async void btn_CreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                
                var user = new UserModel { FirstName = txt_First.Text, LastName = txt_Last.Text,
                    Password = txt_Pass.Text, Email = txt_email.Text, Role = _type,Account=null };
                await _usersServices.CreateUser(user);
                MessageBox.Show("User created:) Now you can Sign In  ");
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }
    }
}

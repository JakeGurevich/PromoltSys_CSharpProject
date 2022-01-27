using Client.Interfaces;
using Client.Models;
using Refit;

namespace Client
{
    public partial class Form1 : Form
    {

        public List<UserModel> uList=new();
        public List<CampaignModel> cList = new();
        public IUsersServices _usersServices;
        public ICampaignServices _campaignServices;

        public Form1(IUsersServices usersServices, ICampaignServices campaignServices)
        {
            InitializeComponent();
            _usersServices = usersServices;
            _campaignServices = campaignServices;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void  btn_GetData_ClickAsync(object sender, EventArgs e)
        {
            uList =await _usersServices.GetUsers();
            dataGridView1.DataSource=uList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btn_CreateUser_Click(object sender, EventArgs e)
        {
            var user = new UserModel { FirstName = txt_First.Text, LastName = txt_Last.Text, Password = txt_Pass.Text, Email = txt_email.Text };
            await _usersServices.CreateUser(user);
            MessageBox.Show("User created ");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btn_GetCampaigns_ClickAsync(object sender, EventArgs e)
        {
            cList = await _campaignServices.GetCampaigns();
            dg_Campains.DataSource=cList;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var campaign= new CampaignModel() { Title=txt_Title.Text,Hashtag=txt_Hashtag.Text,Url=txt_Url.Text,CreatedBy=txt_OwnerId.Text};
            await _campaignServices.CreateCampaign(campaign);
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Last_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
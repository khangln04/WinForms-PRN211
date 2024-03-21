using ProjectPRN.DAL;
using ProjectPRN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class ProfileAdmin : Form
    {
        public ProfileAdmin()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbID.Text);
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            Admin ad = new Admin(id, name, phone, username, password);
            AdminDAO dao = new AdminDAO();
            dao.UpdateAdmin(ad);
            SessionDataAdmin.Admin.Add(ad);
            this.Hide();
            ProfileAdmin form = new ProfileAdmin();
            form.Show();
        }

        private void ProfileAdmin_Load(object sender, EventArgs e)
        {   
            tbID.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbID.Text = SessionDataAdmin.Admin[SessionDataAdmin.Admin.Count - 1].admin_id.ToString();
            tbName.Text = SessionDataAdmin.Admin[SessionDataAdmin.Admin.Count - 1].name.ToString();
            tbPhone.Text = SessionDataAdmin.Admin[SessionDataAdmin.Admin.Count - 1].phone.ToString();
            tbUsername.Text = SessionDataAdmin.Admin[SessionDataAdmin.Admin.Count - 1].username.ToString();
            tbPassword.Text = SessionDataAdmin.Admin[SessionDataAdmin.Admin.Count - 1].password.ToString();
        }

        private void lbAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminAccountPage form = new AdminAccountPage();
            form.Show();
        }

        private void lbCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminHomePage form = new AdminHomePage();
            form.Show();
        }

        private void lbProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProductAdminPage form = new ProductAdminPage();
            form.Show();
        }

        private void lbOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderAdminPage form = new OrderAdminPage();
            form.Show();
        }

        private void lbOrderDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderDetailAdminPage form = new OrderDetailAdminPage();
            form.Show();
        }

        private void lbProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileAdmin form = new ProfileAdmin();
            form.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }
    }
}

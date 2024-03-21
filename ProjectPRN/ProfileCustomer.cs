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
    public partial class ProfileCustomer : Form
    {
        public ProfileCustomer()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCustomerID.Text);
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            Customer cus = new Customer(id, name, phone, address, username, password, "Active");
            CustomerDAO dao = new CustomerDAO();
            dao.UpdateCustomer(cus);
            SessionDataCustomer.Customer.Add(cus);
            this.Hide();
            ProfileCustomer form = new ProfileCustomer();
            form.Show();
        }

        private void ProfileCustomer_Load(object sender, EventArgs e)
        {
            tbCustomerID.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbCustomerID.Text = SessionDataCustomer.Customer[SessionDataCustomer.Customer.Count - 1].customer_id.ToString();
            tbName.Text = SessionDataCustomer.Customer[SessionDataCustomer.Customer.Count - 1].name.ToString();
            tbPhone.Text = SessionDataCustomer.Customer[SessionDataCustomer.Customer.Count - 1].phone.ToString();
            tbAddress.Text = SessionDataCustomer.Customer[SessionDataCustomer.Customer.Count - 1].address.ToString();
            tbUsername.Text = SessionDataCustomer.Customer[SessionDataCustomer.Customer.Count - 1].username.ToString();
            tbPassword.Text = SessionDataCustomer.Customer[SessionDataCustomer.Customer.Count - 1].password.ToString();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void lbProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileCustomer form = new ProfileCustomer();
            form.Show();
        }

        private void lbOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderCustomerPage form = new OrderCustomerPage();
            form.Show();
        }
        
        private void lbHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ClientHomePage form = new ClientHomePage();
            form.Show();
        }



    }
}

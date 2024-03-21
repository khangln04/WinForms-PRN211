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
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            tbCustomerId.Text = "N/A";
            tbCustomerId.ReadOnly = true;
            tbStatus.SelectedIndex = 0;
            tbName.Text = null;
            tbPhone.Text = null;
            tbAddress.Text = null;
            tbUsername.ReadOnly = false;
            tbPassword.Text = null;
            tbUsername.Text = null;
        }

        private void getCustomer(Customer c)
        {
            tbCustomerId.Text = Convert.ToString(c.customer_id);
            tbName.Text = c.name;
            tbPhone.Text = c.phone;
            tbAddress.Text = c.address;

            if (c.status.Equals("Active"))
            {
                tbStatus.SelectedIndex = 0;
            }
            else
            {
                tbStatus.SelectedIndex = 1;
            }
            tbPassword.Text = c.password;
            tbUsername.Text = c.username;
        }

        private Customer UpdateDeleteCustomer()
        {
            int id;
            if (tbCustomerId.Text == "N/A")
            {
                id = 0;
            }
            else
            {
                id = Convert.ToInt32(tbCustomerId.Text);
            }
            int selectedIndex = tbStatus.SelectedIndex;
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAddress.Text;
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string status = tbStatus.Items[selectedIndex].ToString();
            Customer cus = new Customer(id, name, phone, address, username, password, status);
            return cus;
        }
        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            DATAGRIDVIEW.DataSource = customerDAO.GetAllCustomer();
            Clear();
        }

        private void DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbCustomerId.ReadOnly = true;
                tbUsername.ReadOnly = true;
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                string name = row.Cells["name"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString(); ;
                string address = row.Cells["address"].Value.ToString(); ;
                string username = row.Cells["username"].Value.ToString(); ;
                string password = row.Cells["password"].Value.ToString(); ;
                string status = row.Cells["status"].Value.ToString(); ;
                Customer cus = new Customer(id, name, phone, address, username, password, status);
                getCustomer(cus);
            }
        }

        private void DATAGRIDVIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbCustomerId.ReadOnly = true;
                tbUsername.ReadOnly = true;
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                string name = row.Cells["name"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString(); ;
                string address = row.Cells["address"].Value.ToString(); ;
                string username = row.Cells["username"].Value.ToString(); ;
                string password = row.Cells["password"].Value.ToString(); ;
                string status = row.Cells["status"].Value.ToString(); ;
                Customer cus = new Customer(id, name, phone, address, username, password, status);
                getCustomer(cus);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbCustomerId.Text);
            CustomerDAO dao = new CustomerDAO();
            dao.DeleteCustomer(id);
            this.Hide();
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Customer cus = UpdateDeleteCustomer();
            if (cus != null)
            {
                CustomerDAO dao = new CustomerDAO();
                dao.UpdateCustomer(cus);
                this.Hide();
                AdminHomePage adminHomePage = new AdminHomePage();
                adminHomePage.Show();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Customer cus = UpdateDeleteCustomer();
            if (cus != null)
            {
                CustomerDAO dao = new CustomerDAO();
                dao.InsertCustomer(cus);
                this.Hide();
                AdminHomePage adminHomePage = new AdminHomePage();
                adminHomePage.Show();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            CustomerDAO dao = new CustomerDAO();
            DATAGRIDVIEW.DataSource = dao.SearchCustomerbyName(tbSearch.Text);
        }

        private void lbProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileAdmin form = new ProfileAdmin();
            form.Show();
        }

        private void lbOrderDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderDetailAdminPage form = new OrderDetailAdminPage();
            form.Show();
        }

        private void lbOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderAdminPage form = new OrderAdminPage();
            form.Show();
        }

        private void lbProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProductAdminPage form = new ProductAdminPage();
            form.Show();
        }

        private void lbCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminHomePage form = new AdminHomePage();
            form.Show();
        }

        private void lbAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminAccountPage form = new AdminAccountPage();
            form.Show();
        }
    }
}

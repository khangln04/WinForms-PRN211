using ProjectPRN.DAL;
using ProjectPRN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class AdminAccountPage : Form
    {
        AdminDAO dao = new AdminDAO();
        public AdminAccountPage()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            tbAdminId.Text = "N/A";
            tbAdminId.ReadOnly = true;
            tbName.Text = null;
            tbPhone.Text = null;
            tbPassword.Text = null;
            tbUsername.ReadOnly = false;
            tbUsername.Text = null;
        }

        private void getAdmin(Admin c)
        {
            tbAdminId.Text = Convert.ToString(c.admin_id);
            tbName.Text = c.name;
            tbPhone.Text = c.phone;
            tbPassword.Text = c.password;
            tbUsername.Text = c.username;
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbAdminId.Text == "N/A")
            {
                MessageBox.Show("Cannot Update!");
            }
            else
            {
                int id = Convert.ToInt32(tbAdminId.Text);
                string name = tbName.Text;
                string phone = tbPhone.Text;
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                Admin ad = new Admin(id, name, phone, username, password);
                dao.UpdateAdmin(ad);
                this.Hide();
                AdminAccountPage form = new AdminAccountPage();
                form.Show();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbAdminId.Text == "N/A")
            {
                MessageBox.Show("Cannot Delete!");
            }
            else
            {
                int id = Convert.ToInt32(tbAdminId.Text);
                dao.DeleteAdmin(id);
                this.Hide();
                AdminAccountPage form = new AdminAccountPage();
                form.Show();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbAdminId.Text != "N/A")
            {
                MessageBox.Show("Cannot Add Admin!");
            }
            else
            {
                string name = tbName.Text;
                string phone = tbPhone.Text;
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                Admin ad = new Admin(0, name, phone, username, password);
                dao.InsertAdmin(ad);
                this.Hide();
                AdminAccountPage form = new AdminAccountPage();
                form.Show();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void lbProfille_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchAdminbyName(tbSearch.Text);
        }
       
        private void AdminAccountPage_Load(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.GetAllAdmin();
        }

        private void DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tbAdminId.ReadOnly = true;
                tbUsername.ReadOnly = true;
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["admin_id"].Value.ToString());
                string name = row.Cells["name"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString(); ;
                string username = row.Cells["username"].Value.ToString(); ;
                string password = row.Cells["password"].Value.ToString(); ;
                Admin ad = new Admin(id, name, phone, username, password);
                getAdmin(ad);
            }
        }

        private void DATAGRIDVIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbAdminId.ReadOnly = true;
                tbUsername.ReadOnly = true;
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["admin_id"].Value.ToString());
                string name = row.Cells["name"].Value.ToString();
                string phone = row.Cells["phone"].Value.ToString(); ;
                string username = row.Cells["username"].Value.ToString(); ;
                string password = row.Cells["password"].Value.ToString(); ;
                Admin ad = new Admin(id, name, phone, username, password);
                getAdmin(ad);
            }
        }
    }
}

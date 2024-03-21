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
using System.Xml.Linq;

namespace ProjectPRN
{
    public partial class ProductAdminPage : Form
    {   
        ProductDAO dao = new ProductDAO();
        public ProductAdminPage()
        {
            InitializeComponent();
            tbStatus.Items.AddRange(new object[] { "Stocking", "Sold Out" });
            tbStatus.SelectedIndex = 0;
        }
        private void Clear()
        {   
            tbProductId.ReadOnly = true;
            tbProductId.Text = "N/A";
            tbProductName.Text = null;
            tbDescription.Text = null;
            tbImage.Text = null;
            tbPrice.Text = null;
            tbDiscount.Text = null;
            tbStatus.SelectedIndex = 0;
        }

        private void ViewProduct(Product p)
        {
            tbProductId.Text = p.product_id.ToString();
            tbProductName.Text = p.product_name.ToString();
            tbDescription.Text = p.description.ToString();
            tbImage.Text = p.image.ToString();
            tbPrice.Text = p.list_price.ToString();
            tbDiscount.Text = p.discount.ToString();
            btCategory.Text = p.category_name.ToString();

            if (p.status.Equals("Stocking"))
            {
                tbStatus.SelectedIndex = 0;
            }
            if (p.status.Equals("Sold Out"))
            {
                tbStatus.SelectedIndex = 1;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbProductId.Text.Equals("N/A"))
            {
                MessageBox.Show("Cannot Delete");
            }
            else
            {
                int id = Convert.ToInt32(tbProductId.Text);
                dao.DeleteProduct(id);
                this.Hide();
                ProductAdminPage form = new ProductAdminPage();
                form.Show();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbProductId.Text.Equals("N/A"))
            {
                MessageBox.Show("Cannot Update");
            }
            else
            {
                int id = Convert.ToInt32(tbProductId.Text);
                string name = tbProductName.Text;
                string description = tbDescription.Text;
                string image = tbImage.Text;
                double list_price = Convert.ToDouble(tbPrice.Text);
                double discount = Convert.ToDouble(tbDiscount.Text);
                string category_name = btCategory.Text;
                string status = "";
                if(tbStatus.SelectedIndex == 0)
                {
                    status = "Stocking";
                }
                if (tbStatus.SelectedIndex == 1)
                {
                    status = "Sold out";
                }
                Product product = new Product(id, name, description, image, list_price, discount, category_name, status);
                dao.UpdateProduct(product);
                this.Hide();
                ProductAdminPage form = new ProductAdminPage();
                form.Show();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbProductId.Text.Equals("N/A"))
            {
                string name = tbProductName.Text;
                string description = tbDescription.Text;
                string image = tbImage.Text;
                double list_price = Convert.ToDouble(tbPrice.Text);
                double discount = Convert.ToDouble(tbDiscount.Text);
                string category_name = btCategory.Text;
                string status = "";
                if (tbStatus.SelectedIndex == 0)
                {
                    status = "Stocking";
                }
                if (tbStatus.SelectedIndex == 1)
                {
                    status = "Sold out";
                }
                Product product = new Product(0, name, description, image, list_price, discount, category_name, status);
                dao.UpdateProduct(product);
                this.Hide();
                ProductAdminPage form = new ProductAdminPage();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Cannot Update");
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void lbOrderDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderDetailAdminPage form = new OrderDetailAdminPage();
            form.Show();
        }

        private void btProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileAdmin form = new ProfileAdmin();
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

        private void btSearch_TextChanged(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchProductbyName(btSearch.Text);
        }

        private void ProductAdminPage_Load(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.GetAllProduct();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {   
                tbProductId.ReadOnly = true;
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                string name = row.Cells["product_name"].Value.ToString();
                string description = row.Cells["description"].Value.ToString(); 
                string image = row.Cells["image"].Value.ToString(); 
                double list_price = Convert.ToDouble(row.Cells["list_price"].Value.ToString());
                double discount = Convert.ToDouble(row.Cells["discount"].Value.ToString());
                string category_name = row.Cells["category_name"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                Product product = new Product(id, name, description, image, list_price, discount, category_name, status);
                ViewProduct(product);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbProductId.ReadOnly = true;
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                string name = row.Cells["product_name"].Value.ToString();
                string description = row.Cells["description"].Value.ToString(); 
                string image = row.Cells["image"].Value.ToString(); 
                double list_price = Convert.ToDouble(row.Cells["list_price"].Value.ToString());
                double discount = Convert.ToDouble(row.Cells["discount"].Value.ToString());
                string category_name = row.Cells["category_name"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                Product product = new Product(id, name, description, image, list_price, discount, category_name, status);
                ViewProduct(product);
            }
        }

    }
}

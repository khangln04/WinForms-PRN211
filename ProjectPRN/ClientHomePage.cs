using Microsoft.VisualBasic.Devices;
using ProjectPRN.DAL;
using ProjectPRN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class ClientHomePage : Form
    {
        ProductDAO dao = new ProductDAO();
        public ClientHomePage()
        {
            InitializeComponent();
            List<String> list = dao.GetAllCategory();
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "category_name";
            tbCountProductForCategory.Text = Convert.ToString(dao.CountAllProduct());
        }
        private void ViewProduct(Product p)
        {
            tbProductID.Text = p.product_id.ToString();
            tbName.Text = p.product_name.ToString();
            tbDecription.Text = p.description.ToString();
            tbImage.Text = p.image.ToString();
            tbPrice.Text = p.list_price.ToString();
            tbDiscount.Text = p.discount.ToString();
        }
        private void tbSreach_TextChanged(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchProductbyName(tbSreach.Text);
        }

        private void tbSearchbyPriceFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int from = Convert.ToInt32(tbSearchbyPriceFrom.Text.ToString());
                int to = Convert.ToInt32(tbSearchbyPriceTo.Text.ToString());
                DATAGRIDVIEW.DataSource = dao.SearchProductbyPrice(from, to);
            }
            catch
            {
                DATAGRIDVIEW.DataSource = dao.GetAllProduct();
            }
        }

        private void tbSearchbyPriceTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int from = Convert.ToInt32(tbSearchbyPriceFrom.Text.ToString());
                int to = Convert.ToInt32(tbSearchbyPriceTo.Text.ToString());
                DATAGRIDVIEW.DataSource = dao.SearchProductbyPrice(from, to);
            }
            catch
            {
                DATAGRIDVIEW.DataSource = dao.GetAllProduct();
            }
        }

        private void ClientHomePage_Load(object sender, EventArgs e)
        {
            tbProductID.ReadOnly = true;
            tbName.ReadOnly = true;
            tbDecription.ReadOnly = true;
            tbImage.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbDiscount.ReadOnly = true;
            DATAGRIDVIEW.DataSource = dao.GetAllProduct();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = dao.CountAllProductforCategory(cbCategory.SelectedValue.ToString());
            DATAGRIDVIEW.DataSource = dao.SearchProductByCategory(cbCategory.SelectedValue.ToString());
            tbCountProductForCategory.Text = Convert.ToString(n);
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            OrderDAO daoO = new OrderDAO();
            OrderDetailDAO daoOD = new OrderDetailDAO();
            List<Product> pro = new List<Product>();
            double total_price = 0;
            foreach (DataGridViewRow row in DATAGRIDVIEW.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["product_id"].Value);
                string name = row.Cells["product_name"].Value.ToString();
                string description = row.Cells["description"].Value.ToString();
                string image = row.Cells["image"].Value.ToString();
                double list_price = Convert.ToDouble(row.Cells["list_price"].Value);
                double discount = Convert.ToDouble(row.Cells["discount"].Value);
                string category_name = row.Cells["category_name"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();

                Product product = new Product(id, name, description, image, list_price, discount, category_name, status);
                pro.Add(product);
            }

            foreach (Product product in pro)
            {
                total_price += product.list_price;
            }

            Order oder = new Order(0, SessionDataCustomer.Customer[0].customer_id,
            SessionDataCustomer.Customer[0].name, SessionDataCustomer.Customer[0].phone,
            SessionDataCustomer.Customer[0].address, total_price, DateTime.Now, "Wait");
            daoO.InsertOrder(oder);


            foreach (Product product in pro)
            {
                OrderDetail detail = new OrderDetail(0, daoO.GetIdofOrdertoOrderDetail(), SessionDataCustomer.Customer[0].customer_id,
                    product.product_id, product.product_name, product.image, product.list_price, 1);
                daoOD.InsertOrderDetail(detail);
            }
            this.Hide();
            CheckoutCustomerPage from = new CheckoutCustomerPage();
            from.Show();
        }

        private void tbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lbHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ClientHomePage from = new ClientHomePage();
            from.Show();
        }

        private void lbOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            OrderCustomerPage from = new OrderCustomerPage();
            from.Show();
        }

        private void lbProfle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileCustomer from = new ProfileCustomer();
            from.Show();
        }

        private void DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                string name = row.Cells["product_name"].Value.ToString();
                string description = row.Cells["description"].Value.ToString(); ;
                string image = row.Cells["image"].Value.ToString(); ;
                double list_price = Convert.ToDouble(row.Cells["list_price"].Value.ToString());
                double discount = Convert.ToDouble(row.Cells["discount"].Value.ToString());
                string category_name = row.Cells["category_name"].Value.ToString();
                string status = row.Cells["status"].Value.ToString();
                Product product = new Product(id, name, description, image, list_price, discount, category_name, status);
                ViewProduct(product);
            }
        }

        private void DATAGRIDVIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                string name = row.Cells["product_name"].Value.ToString();
                string description = row.Cells["description"].Value.ToString(); ;
                string image = row.Cells["image"].Value.ToString(); ;
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

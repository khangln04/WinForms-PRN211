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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Xml.Linq;

namespace ProjectPRN
{
    public partial class OrderDetailAdminPage : Form
    {
        OrderDetailDAO dao = new OrderDetailDAO();
        public int id { get; set; }
        public OrderDetailAdminPage()
        {
            InitializeComponent();
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchOrderDetailByProduct(tbSearch.Text);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void OrderDetailAdminPage_Load(object sender, EventArgs e)
        {
            if (id == 0 || id == null)
            {
                DATAGRIDVIEW.DataSource = dao.GetAllOrderDetail();
            }
            else
            {
                DATAGRIDVIEW.DataSource = dao.GetOrderDetail(id);
                id = 0;
            }
        }

        private void ViewOrderDetail(OrderDetail od)
        {
            btOrderdetailID.Text = Convert.ToString(od.order_id);
            tbOrderID.Text = Convert.ToString(od.order_id);
            tbCustomerID.Text = Convert.ToString(od.customer_id);
            tbProductID.Text = Convert.ToString(od.product_id);
            tbProductName.Text = od.product_name;
            tbImage.Text = od.image;
            tbPrice.Text = Convert.ToString(od.list_price);
            tbQuantityOrder.Text = Convert.ToString(od.quantity_order);
        }

        private void DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int orderdetail_id = Convert.ToInt32(row.Cells["orderdetail_id"].Value.ToString());
                int order_id = Convert.ToInt32(row.Cells["order_id"].Value.ToString());
                int customer_id = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                int product_id = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                string product_name = row.Cells["product_name"].Value.ToString(); ;
                string image = row.Cells["image"].Value.ToString(); ;
                double list_price = Convert.ToDouble(row.Cells["list_price"].Value.ToString());
                int quantity_order = Convert.ToInt32(row.Cells["quantity_order"].Value.ToString());
                OrderDetail orderDetail = new OrderDetail(orderdetail_id,order_id,
                    customer_id,product_id,product_name,image,list_price,quantity_order);
                ViewOrderDetail(orderDetail);
            }
        }
        private void DATAGRIDVIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int orderdetail_id = Convert.ToInt32(row.Cells["orderdetail_id"].Value.ToString());
                int order_id = Convert.ToInt32(row.Cells["order_id"].Value.ToString());
                int customer_id = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                int product_id = Convert.ToInt32(row.Cells["product_id"].Value.ToString());
                string product_name = row.Cells["product_name"].Value.ToString(); ;
                string image = row.Cells["image"].Value.ToString(); ;
                double list_price = Convert.ToDouble(row.Cells["list_price"].Value.ToString());
                int quantity_order = Convert.ToInt32(row.Cells["quantity_order"].Value.ToString());
                OrderDetail orderDetail = new OrderDetail(orderdetail_id, order_id,
                    customer_id, product_id, product_name, image, list_price, quantity_order);
                ViewOrderDetail(orderDetail);
            }
        }
    }
}

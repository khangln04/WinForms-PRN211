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
    public partial class OrderAdminPage : Form
    {
        OrderDAO dao = new OrderDAO();
        public OrderAdminPage()
        {
            InitializeComponent();
            tbStatus.Items.AddRange(new object[] { "Wait", "Process", "Done" });
            tbStatus.SelectedIndex = 0;
            lbWait.Text = "Wait: " + dao.CountStatusOrder("Wait");
            lbProcess.Text = "Process: " + dao.CountStatusOrder("Process");
            lbDone.Text = "Done: " + dao.CountStatusOrder("Done");
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
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

        private void lbWait_Click(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchOrderbyStatus("Wait");
        }

        private void lbProcess_Click(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchOrderbyStatus("Process");
        }

        private void lbDone_Click(object sender, EventArgs e)
        {
            DATAGRIDVIEW.DataSource = dao.SearchOrderbyStatus("Done");
        }

        private void ViewOrder(Order od)
        {
            tbOrderID.Text = Convert.ToString(od.order_id);
            tbCustomerId.Text = Convert.ToString(od.customer_id);
            tbName.Text = od.name_receiver;
            tbPhone.Text = od.phone_receiver;
            tbDate.Value = od.date;
            tbAdress.Text = od.address_receiver;
            tbPrice.Text = Convert.ToString(od.total_price);
            if (od.status.Equals("Wait"))
            {
                tbStatus.Items.Clear();
                tbStatus.Items.Add("Wait");
                tbStatus.Items.Add("Process");
                tbStatus.SelectedIndex = 0;
            }
            if (od.status.Equals("Process"))
            {
                tbStatus.Items.Clear();
                tbStatus.Items.Add("Wait");
                tbStatus.Items.Add("Process");
                tbStatus.Items.Add("Done");
                tbStatus.SelectedIndex = 1;
            }
            if (od.status.Equals("Done"))
            {
                tbStatus.Items.Clear();
                tbStatus.Items.Add("Done");
                tbStatus.SelectedIndex = 0;
            }
        }
        private void InitializeDataGridView()
        {
            DataGridViewButtonColumn detailColumn = new DataGridViewButtonColumn();
            detailColumn.Name = "Detail";
            detailColumn.HeaderText = "Detail";
            detailColumn.Text = "Detail";
            detailColumn.UseColumnTextForButtonValue = true;
            detailColumn.DisplayIndex = DATAGRIDVIEW.Columns.Count;
            DATAGRIDVIEW.Columns.Add(detailColumn);
        }

        private void DATAGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DATAGRIDVIEW.Columns["Detail"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(DATAGRIDVIEW.Rows[e.RowIndex].Cells["order_id"].Value);
                this.Hide();
                OrderDetailAdminPage form = new OrderDetailAdminPage();
                form.id = id;
                form.Show();
            }
        }

        private void DATAGRIDVIEW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DATAGRIDVIEW.Rows[e.RowIndex];
                int order_id = Convert.ToInt32(row.Cells["order_id"].Value.ToString());
                int customer_id = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                string name_receiver = row.Cells["name_receiver"].Value.ToString(); ;
                string phone_receiver = row.Cells["phone_receiver"].Value.ToString(); ;
                string address_receiver = row.Cells["address_receiver"].Value.ToString();
                double price = Convert.ToDouble(row.Cells["total_price"].Value.ToString());
                DateTime date = Convert.ToDateTime(row.Cells["date"].Value.ToString());
                string status = row.Cells["status"].Value.ToString();
                Order order = new Order(order_id, customer_id, name_receiver,
                    phone_receiver, address_receiver, price, date, status);
                ViewOrder(order);
            }
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            int order_id = Convert.ToInt32(tbOrderID.Text.ToString());
            string status = "";
            if(tbStatus.SelectedIndex == 0)
            {
                status = "Wait";
            }
            if (tbStatus.SelectedIndex == 1)
            {
                status = "Process";
            }
            if (tbStatus.SelectedIndex == 2)
            {
                status = "Done";
            }
            dao.UpdateOrderStatus(status, order_id);
            this.Hide();
            OrderAdminPage form = new OrderAdminPage();
            form.Show();
        }

        private void OrderAdminPage_Load(object sender, EventArgs e)
        {
            tbOrderID.ReadOnly = true;
            tbCustomerId.ReadOnly = true;
            tbName.ReadOnly = true;
            tbDate.Enabled = false;
            tbPhone.ReadOnly = true; 
            tbAdress.ReadOnly = true;
            tbPrice.ReadOnly = true;
            DATAGRIDVIEW.DataSource = dao.GetAllOrder();
            InitializeDataGridView();
        }
    }
}

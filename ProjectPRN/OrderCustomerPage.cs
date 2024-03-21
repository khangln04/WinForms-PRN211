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
    public partial class OrderCustomerPage : Form
    {   
        OrderDAO dao = new OrderDAO();
        public OrderCustomerPage()
        {
            InitializeComponent();
            
            lbDone.Text = "Done: " + dao.CountStatusOrderbyCustomer("Done", SessionDataCustomer.Customer[0].customer_id);
            lbProcess.Text = "Process: " + dao.CountStatusOrderbyCustomer("Process", SessionDataCustomer.Customer[0].customer_id);
            lbWait.Text = "Wait: " + dao.CountStatusOrderbyCustomer("Wait", SessionDataCustomer.Customer[0].customer_id);
        }
        private void InitializeDataGridView()
        {
            DataGridViewButtonColumn detailColumn = new DataGridViewButtonColumn();
            detailColumn.Name = "Detail";
            detailColumn.HeaderText = "Detail";
            detailColumn.Text = "Detail";
            detailColumn.UseColumnTextForButtonValue = true;
            detailColumn.DisplayIndex = dataGridView1.Columns.Count;
            dataGridView1.Columns.Add(detailColumn);
        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login from = new Login();
            from.Show();
        }

        private void OrderCustomerPage_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = dao.GetAllOrderCustomer(SessionDataCustomer.Customer[0].customer_id);
            InitializeDataGridView();
        }

        private void lbWait_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.SearchOrderbyStatusCustomer("Wait", SessionDataCustomer.Customer[0].customer_id);
        }

        private void lbProcess_Click(object sender, EventArgs e)
        {   
            dataGridView1.DataSource = dao.SearchOrderbyStatusCustomer("Process", SessionDataCustomer.Customer[0].customer_id);
        }

        private void lbDone_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dao.SearchOrderbyStatusCustomer("Done", SessionDataCustomer.Customer[0].customer_id);
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


        private void lbProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileCustomer from = new ProfileCustomer();
            from.Show();
        }

        private void ViewOrder(Order od)
        {
            tbOrderID.Text = Convert.ToString(od.order_id);
            tbCustomerID.Text = Convert.ToString(od.customer_id);
            tbName.Text = od.name_receiver;
            tbPhone.Text = od.phone_receiver;
            tbDate.Value = od.date;
            tbAddress.Text = od.address_receiver;
            tbPrice.Text = Convert.ToString(od.total_price);
            tbStatus.Text = od.status;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["order_id"].Value);
                OrderDetailDAO daoOD = new OrderDetailDAO();
                dataGridView1.DataSource = daoOD.GetOrderDetail(id);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int order_id = Convert.ToInt32(row.Cells["order_id"].Value.ToString());
                int customer_id = Convert.ToInt32(row.Cells["customer_id"].Value.ToString());
                string name_receiver = row.Cells["name_receiver"].Value.ToString(); ;
                string phone_receiver = row.Cells["phone_receiver"].Value.ToString(); ;
                string address_receiver = row.Cells["address_receiver"].Value.ToString();
                double price = Convert.ToDouble(row.Cells["total_price"].Value.ToString());
                DateTime date = Convert.ToDateTime(row.Cells["date"].Value.ToString());
                string status = row.Cells["status"].Value.ToString();
                Order order = new Order(order_id,customer_id,name_receiver,
                    phone_receiver,address_receiver,price,date,status);
                ViewOrder(order);
            }
        }
    }
}

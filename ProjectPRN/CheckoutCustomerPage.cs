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
    public partial class CheckoutCustomerPage : Form
    {
        OrderDetailDAO daoOD = new OrderDetailDAO();
        OrderDAO dao = new OrderDAO();
        public CheckoutCustomerPage()
        {
            InitializeComponent();
        }

        private void CheckoutCustomerPage_Load(object sender, EventArgs e)
        {   
            // load data
            dataGridView1.DataSource = dao.GetOrder(dao.GetIdofOrdertoOrderDetail());
            dataGridView2.DataSource = daoOD.GetOrderDetail(dao.GetIdofOrdertoOrderDetail());

            // Set data
            List<Order> od = dao.GetOrder(dao.GetIdofOrdertoOrderDetail());
            tbOrderId.ReadOnly = true;
            tbCustomerId.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbDate.Enabled = false;
            tbStatus.ReadOnly = true;

            tbOrderId.Text = Convert.ToString(od[0].order_id);
            tbCustomerId.Text = Convert.ToString(od[0].customer_id);
            tbName.Text = od[0].name_receiver;
            tbPhone.Text = od[0].phone_receiver;
            tbAddress.Text = od[0].address_receiver;
            tbPrice.Text = Convert.ToString(od[0].total_price);
            tbDate.Value = od[0].date;
            tbStatus.Text = od[0].status;
        }

        private void btCancelOrder_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                daoOD.DeleteOrderdetail(dao.GetIdofOrdertoOrderDetail());
                dao.DeleteOrder(dao.GetIdofOrdertoOrderDetail());
                this.Hide();
                ClientHomePage from = new ClientHomePage();
                from.Show();
            }
        }

        private void btSubmitOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientHomePage from = new ClientHomePage();
            from.Show();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbOrderId.Text);
            string name = tbName.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;
            dao.UpdateOrder(name,phone,address,id);
            this.Hide();
            CheckoutCustomerPage from = new CheckoutCustomerPage();
            from.Show();
        }
    }
}

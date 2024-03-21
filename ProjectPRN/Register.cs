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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private Customer AddCustomer()
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string address = tbAdress.Text;
            string username = tbUsername.Text;
            string password = tbPassowrd.Text;
            Customer cus = new Customer(0, name, phone, address, username, password, "Active");
            return cus;
        }
        private void tbSubmit_Click(object sender, EventArgs e)
        {
            Customer cus = AddCustomer();
            if (cus != null)
            {
                CustomerDAO dao = new CustomerDAO();
                dao.InsertCustomer(cus);
            }
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


    }
}

using ProjectPRN.DAL;
using ProjectPRN.Model;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            cbRole.Items.Add("Customer");
            cbRole.Items.Add("Admin");
            cbRole.SelectedIndex = 0;
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            AdminDAO adminDAO = new AdminDAO();
            CustomerDAO customerDAO = new CustomerDAO();
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if (cbRole.SelectedIndex.Equals(1))
            {
                Admin admin = new Admin(username, password);
                if (adminDAO.Login(admin))
                {
                    List<Admin> list = adminDAO.GetAdminByAccount(admin);
                    SessionDataAdmin.Admin.Add(list[0]);
                    this.Hide();
                    AdminHomePage form = new AdminHomePage();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password Error! Pls Enter Again!");
                }
            }
            if (cbRole.SelectedIndex.Equals(0))
            {
                Customer customer = new Customer(username, password);
                if (customerDAO.Login(customer))
                {
                    List<Customer> list = customerDAO.GetCustomerByAccount(customer);
                    SessionDataCustomer.Customer.Add(list[0]);
                    this.Hide();
                    ClientHomePage form = new ClientHomePage();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password Error! Pls Enter Again!");
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register form = new Register();
            form.Show();
        }

    }
}



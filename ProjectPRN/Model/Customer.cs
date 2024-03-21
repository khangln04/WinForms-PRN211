using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Model
{
    internal class Customer
    {

        public int customer_id { get; set; }
        public string name { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string status { get; set; }

        public Customer(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Customer(int customer_id, string name, string phone, string address, string username, string password, string status)
        {
            this.customer_id = customer_id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.username = username;
            this.password = password;
            this.status = status;
        }
    }
    internal static class SessionDataCustomer
    {
        public static List<Customer> Customer { get; set; } = new List<Customer>();
    }

}

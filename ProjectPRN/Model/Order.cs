using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Model
{
    internal class Order
    {

        public int order_id { get; set; }
        public int customer_id { get; set; }

        public string name_receiver { get; set; }

        public string phone_receiver { get; set; }

        public string address_receiver { get; set; }

        public double total_price { get; set; }

        public DateTime date { get; set; }

        public string status { get; set; }


        public Order()
        {
        }

        public Order(int order_id, int customer_id, string name_receiver, string phone_receiver, string address_receiver, double total_price, DateTime date, string status)
        {
            this.order_id = order_id;
            this.customer_id = customer_id;
            this.name_receiver = name_receiver;
            this.phone_receiver = phone_receiver;
            this.address_receiver = address_receiver;
            this.total_price = total_price;
            this.date = date;
            this.status = status;
        }

    }
}

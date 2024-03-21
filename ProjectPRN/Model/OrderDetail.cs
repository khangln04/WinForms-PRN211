using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Model
{
    internal class OrderDetail
    {

        public int orderdetail_id { get; set; }
        public int order_id { get; set; }

        public int customer_id { get; set; }

        public int product_id { get; set; }

        public string product_name { get; set; }

        public string image { get; set; }

        public double list_price { get; set; }

        public int quantity_order { get; set; }

        public OrderDetail()
        {
        }
        public OrderDetail(int orderdetail_id, int order_id, int customer_id, int product_id, string product_name, string image, double list_price, int quantity_order)
        {
            this.orderdetail_id = orderdetail_id;
            this.order_id = order_id;
            this.customer_id = customer_id;
            this.product_id = product_id;
            this.product_name = product_name;
            this.image = image;
            this.list_price = list_price;
            this.quantity_order = quantity_order;
        }

    }
}

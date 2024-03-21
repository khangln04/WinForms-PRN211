using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Model
{
    internal class Product
    {

        public int product_id { get; set; }
        public string product_name { get; set; }

        public string description { get; set; }

        public string image { get; set; }

        public double list_price { get; set; }

        public double discount { get; set; }

        public string category_name { get; set; }

        public string status { get; set; }

        public Product()
        {
        }

        public Product(int product_id, string product_name, string description, string image, double list_price, double discount, string category_name, string status)
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.description = description;
            this.image = image;
            this.list_price = list_price;
            this.discount = discount;
            this.category_name = category_name;
            this.status = status;
        }
    }
}

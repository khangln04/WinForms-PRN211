using Microsoft.Data.SqlClient;
using ProjectPRN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DAL
{
    internal class OrderDetailDAO
    {
        public  List<OrderDetail> GetAllOrderDetail()
        {
            List<OrderDetail> list = new List<OrderDetail>();
            string sql = "SELECT * FROM order_detail";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
  
                            list.Add(new OrderDetail(
                            Convert.ToInt32(dr["orderdetail_id"]),
                            Convert.ToInt32(dr["order_id"]),
                            Convert.ToInt32(dr["customer_id"]),
                            Convert.ToInt32(dr["product_id"]),
                            dr["product_name"].ToString(),
                            dr["image"].ToString(),
                            Convert.ToDouble(dr["list_price"]),
                            Convert.ToInt32(dr["quantity_order"])));
            }
            return list;
        }
        public List<OrderDetail> SearchOrderDetailByProduct(string name)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            string sql = "SELECT * FROM order_detail WHERE product_name like '%' + @name + '%'";
            SqlParameter parameters = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters.Value = name;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new OrderDetail(
                           Convert.ToInt32(dr["orderdetail_id"]),
                           Convert.ToInt32(dr["order_id"]),
                           Convert.ToInt32(dr["customer_id"]),
                           Convert.ToInt32(dr["product_id"]),
                           dr["product_name"].ToString(),
                           dr["image"].ToString(),
                           Convert.ToDouble(dr["list_price"]),
                           Convert.ToInt32(dr["quantity_order"])));
                }
                return list;
            }
        }


        public List<OrderDetail> GetOrderDetail(int id)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            string sql = "SELECT * FROM order_detail WHERE order_id = @id";
            SqlParameter parameters = new SqlParameter("@id", DbType.Int32);
            parameters.Value = id;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new OrderDetail(
                           Convert.ToInt32(dr["orderdetail_id"]),
                           Convert.ToInt32(dr["order_id"]),
                           Convert.ToInt32(dr["customer_id"]),
                           Convert.ToInt32(dr["product_id"]),
                           dr["product_name"].ToString(),
                           dr["image"].ToString(),
                           Convert.ToDouble(dr["list_price"]),
                           Convert.ToInt32(dr["quantity_order"])));
                }
                return list;
            }
        }

        public void InsertOrderDetail (OrderDetail c)
        {
            string sql = @"INSERT INTO [dbo].[order_detail]
           ([order_id]
           ,[customer_id]
           ,[product_id]
           ,[product_name]
           ,[image]
           ,[list_price]
           ,[quantity_order])
             VALUES
           (@order_id, @customer_id , @product_id , @product_name , @image, @list_price , @quantity_order)";
            SqlParameter param1 = new SqlParameter("@order_id", SqlDbType.Int);
            param1.Value = c.order_id;
            SqlParameter param2 = new SqlParameter("@customer_id", SqlDbType.Int);
            param2.Value = c.customer_id;
            SqlParameter param3 = new SqlParameter("@product_id", SqlDbType.Int);
            param3.Value = c.product_id;
            SqlParameter param4 = new SqlParameter("@product_name", SqlDbType.NVarChar);
            param4.Value = c.product_name;
            SqlParameter param5 = new SqlParameter("@image", SqlDbType.NVarChar);
            param5.Value = c.image;
            SqlParameter param6 = new SqlParameter("@list_price", SqlDbType.Float);
            param6.Value = c.list_price;
            SqlParameter param7 = new SqlParameter("@quantity_order", SqlDbType.Float);
            param7.Value = c.quantity_order;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5, param6, param7);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }
        }

        public void DeleteOrderdetail(int Id)
        {
            string sql = @"DELETE FROM [dbo].[order_detail]
                         WHERE order_id = @id";
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int);
            param.Value = Id;
            try
            {
                DAO.ExecuteSQL(sql, param);
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("This attribute is already a foreign key in another table!");
            }
        }

    }
}

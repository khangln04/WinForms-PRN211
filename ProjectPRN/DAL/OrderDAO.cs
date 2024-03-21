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
    internal class OrderDAO
    {
        public  List<Order> GetAllOrder()
        {
            List<Order> list = new List<Order>();
            string sql = "SELECT * FROM orders";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
 
            list.Add(new Order(
                        Convert.ToInt32(dr["order_id"]),
                        Convert.ToInt32(dr["customer_id"]),
                        dr["name_receiver"].ToString(),
                        dr["phone_receiver"].ToString(),
                        dr["address_receiver"].ToString(),
                        Convert.ToDouble(dr["price"]),
                        Convert.ToDateTime(dr["date"]),
                        dr["status"].ToString()));
            }
            return list;
        }

        public List<Order> GetAllOrderCustomer(int id)
        {
            List<Order> list = new List<Order>();
            string sql = "SELECT * FROM orders where customer_id = @id";
            SqlParameter parameters = new SqlParameter("@id", SqlDbType.Int);
            parameters.Value = id;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            foreach (DataRow dr in dt.Rows)
            {

                list.Add(new Order(
                            Convert.ToInt32(dr["order_id"]),
                            Convert.ToInt32(dr["customer_id"]),
                            dr["name_receiver"].ToString(),
                            dr["phone_receiver"].ToString(),
                            dr["address_receiver"].ToString(),
                            Convert.ToDouble(dr["price"]),
                            Convert.ToDateTime(dr["date"]),
                            dr["status"].ToString()));
            }
            return list;
        }

        public int GetIdofOrdertoOrderDetail()
        {
            int n = 0;
            string sql = "SELECT top (1) order_id FROM orders order by order_id desc";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {

                n = Convert.ToInt32(dr["order_id"]);
            }
            return n;
        }
        

        public  List<Order> GetOrder(int id)
        {
            List<Order> list = new List<Order>();
            string sql = "SELECT * FROM orders WHERE order_id = @id";
            SqlParameter parameters = new SqlParameter("@id", SqlDbType.Int);
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
                    list.Add(new Order(
                        Convert.ToInt32(dr["order_id"]),
                        Convert.ToInt32(dr["customer_id"]),
                        dr["name_receiver"].ToString(),
                        dr["phone_receiver"].ToString(),
                        dr["address_receiver"].ToString(),
                        Convert.ToDouble(dr["price"]),
                        Convert.ToDateTime(dr["date"]),
                        dr["status"].ToString()));
                }
                return list;
            }
        }

        public  List<Order> SearchOrderbyStatus(string status)
        {
            List<Order> list = new List<Order>();
            string sql = "SELECT * FROM orders WHERE status like '%' + @status + '%' ";
            SqlParameter parameters = new SqlParameter("@status", SqlDbType.NVarChar);
            parameters.Value = status;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Order(
                       Convert.ToInt32(dr["order_id"]),
                       Convert.ToInt32(dr["customer_id"]),
                       dr["name_receiver"].ToString(),
                       dr["phone_receiver"].ToString(),
                       dr["address_receiver"].ToString(),
                       Convert.ToDouble(dr["price"]),
                       Convert.ToDateTime(dr["date"]),
                       dr["status"].ToString()));
                }
                return list;
            }
        }

        public List<Order> SearchOrderbyStatusCustomer(string status, int id)
        {
            List<Order> list = new List<Order>();
            string sql = "SELECT * FROM orders WHERE status like '%' + @status + '%' and customer_id = @id ";
            SqlParameter parameters = new SqlParameter("@status", SqlDbType.NVarChar);
            parameters.Value = status;
            SqlParameter parameters1 = new SqlParameter("@id", SqlDbType.Int);
            parameters1.Value = id;
            DataTable dt = DAO.GetDataBySql(sql, parameters, parameters1);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Order(
                       Convert.ToInt32(dr["order_id"]),
                       Convert.ToInt32(dr["customer_id"]),
                       dr["name_receiver"].ToString(),
                       dr["phone_receiver"].ToString(),
                       dr["address_receiver"].ToString(),
                       Convert.ToDouble(dr["price"]),
                       Convert.ToDateTime(dr["date"]),
                       dr["status"].ToString()));
                }
                return list;
            }
        }

        public int CountStatusOrderbyCustomer(string status, int id)
        {
            List<Order> list = new List<Order>();
            int count = 0;
            string sql = "SELECT COUNT(order_id) as count FROM orders WHERE status like '%' + @status + '%' and customer_id = @id ";
            SqlParameter parameters = new SqlParameter("@status", SqlDbType.NVarChar);
            parameters.Value = status;
            SqlParameter parameters1 = new SqlParameter("@id", SqlDbType.Int);
            parameters1.Value = id;
            DataTable dt = DAO.GetDataBySql(sql, parameters, parameters1);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    count = Convert.ToInt32(dr["count"]);
                }
                return count;
            }
        }

        public int CountStatusOrder(string status)
        {
            List<Order> list = new List<Order>();
            int count = 0;
            string sql = "SELECT COUNT(order_id) as count FROM orders WHERE status like '%' + @status + '%' ";
            SqlParameter parameters = new SqlParameter("@status", SqlDbType.NVarChar);
            parameters.Value = status;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            if (dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    count = Convert.ToInt32(dr["count"]);
                }
                return count;
            }
        }

        public void UpdateOrderStatus(String status, int id)
        {
            string sql = @"UPDATE [dbo].[orders]
            SET  [status] = @status
            WHERE order_id = @id";
            SqlParameter param1 = new SqlParameter("@status", SqlDbType.VarChar);
            param1.Value = status;
            SqlParameter param2 = new SqlParameter("@id", SqlDbType.Int);
            param2.Value = id;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2);
                MessageBox.Show("Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }
        }

        public void UpdateOrder(string name, string phone, string address, int id)
        {
            string sql = @"UPDATE[dbo].[orders]
                SET
                 [name_receiver] = @name_receiver
                ,[phone_receiver] = @phone_receiver
                ,[address_receiver] = @address_receiver
                WHERE order_id = @order_id ";
            SqlParameter param1 = new SqlParameter("@name_receiver", SqlDbType.NVarChar);
            param1.Value = name;
            SqlParameter param2 = new SqlParameter("@phone_receiver", SqlDbType.NVarChar);
            param2.Value = phone;
            SqlParameter param3 = new SqlParameter("@address_receiver", SqlDbType.NVarChar);
            param3.Value = address;
            SqlParameter param4 = new SqlParameter("@order_id", SqlDbType.Int);
            param4.Value = id;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4);
                MessageBox.Show("Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }
        }

        public void InsertOrder(Order c)
        {
            string sql = @"INSERT INTO [dbo].[orders]
           ([customer_id]
           ,[name_receiver]
           ,[phone_receiver]
           ,[address_receiver]
           ,[price]
           ,[date]
           ,[status])
     VALUES
           (@customer_id, @name_receiver, @phone_receiver , @address_receiver , @price , @date, @status)";
            SqlParameter param1 = new SqlParameter("@customer_id", SqlDbType.Int);
            param1.Value = c.customer_id;
            SqlParameter param2 = new SqlParameter("@name_receiver", SqlDbType.NVarChar);
            param2.Value = c.name_receiver;
            SqlParameter param3 = new SqlParameter("@phone_receiver", SqlDbType.NVarChar);
            param3.Value = c.phone_receiver;
            SqlParameter param4 = new SqlParameter("@address_receiver", SqlDbType.NVarChar);
            param4.Value = c.address_receiver;
            SqlParameter param5 = new SqlParameter("@price", SqlDbType.Float);
            param5.Value = c.total_price;
            SqlParameter param6 = new SqlParameter("@date", SqlDbType.Date);
            param6.Value = c.date;
            SqlParameter param7 = new SqlParameter("@status", SqlDbType.NVarChar);
            param7.Value = c.status;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5, param6, param7);
                MessageBox.Show("A New Order Is Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }
        }

        public void DeleteOrder(int Id)
        {
            string sql = @"DELETE FROM [dbo].[orders]
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

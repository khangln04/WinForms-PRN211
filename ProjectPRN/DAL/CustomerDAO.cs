using Microsoft.Data.SqlClient;
using ProjectPRN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.DAL
{
    internal class CustomerDAO
    {
       

        public List<Customer> GetAllCustomer()
        {
            List<Customer> list = new List<Customer>();
            string sql = "SELECT * FROM customer";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {

                list.Add(new Customer(
                        Convert.ToInt32(dr["customer_id"]),
                        dr["name"].ToString(),
                        dr["phone"].ToString(),
                        dr["address"].ToString(),
                        dr["username"].ToString(),
                        dr["password"].ToString(),
                        dr["status"].ToString()));
            }
            return list;
        }
        public List<Customer> GetCustomer(int id)
        {
            List<Customer> list = new List<Customer>();
            string sql = "SELECT * FROM customer WHERE customer_id = @id";
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
                    list.Add(new Customer(
                       Convert.ToInt32(dr["customer_id"]),
                       dr["name"].ToString(),
                       dr["phone"].ToString(),
                       dr["address"].ToString(),
                       dr["username"].ToString(),
                       dr["password"].ToString(),
                       dr["status"].ToString()));
                }
                return list;
            }
        }
        public List<Customer> GetCustomerByAccount(Customer c)
        {
            List<Customer> list = new List<Customer>();
            string sql = "SELECT * FROM customer WHERE username LIKE '%' + @user + '%' AND password LIKE '%' + @password + '%'";
            SqlParameter parameters = new SqlParameter("@user", SqlDbType.NVarChar);
            parameters.Value = c.username;
            SqlParameter parameters1 = new SqlParameter("@password", SqlDbType.NVarChar);
            parameters1.Value = c.password;
            DataTable dt = DAO.GetDataBySql(sql, parameters, parameters1);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Customer(
                       Convert.ToInt32(dr["customer_id"]),
                       dr["name"].ToString(),
                       dr["phone"].ToString(),
                       dr["address"].ToString(),
                       dr["username"].ToString(),
                       dr["password"].ToString(),
                       dr["status"].ToString()));
                }
                return list;
            }
        }

        public List<Customer> SearchCustomerbyName(string name)
        {
            List<Customer> list = new List<Customer>();
            string sql = "SELECT * FROM customer WHERE name like '%' + @name + '%' ";
            SqlParameter parameters = new SqlParameter("@name", name);
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
                    list.Add(new Customer(
                        Convert.ToInt32(dr["customer_id"]),
                        dr["name"].ToString(),
                        dr["phone"].ToString(),
                        dr["address"].ToString(),
                        dr["username"].ToString(),
                        dr["password"].ToString(),
                        dr["status"].ToString()));
                }
                return list;
            }
        }

        public void UpdateCustomer(Customer c)
        {
            string sql = @"UPDATE [dbo].[customer]
   SET [name] = @name
      ,[phone] = @phone
      ,[address] = @address
      ,[username] = @username
      ,[password] = @password
      ,[status] = @status
 WHERE  customer_id = @id ";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = c.name;
            SqlParameter param2 = new SqlParameter("@phone", SqlDbType.NVarChar);
            param2.Value = c.phone;
            SqlParameter param3 = new SqlParameter("@address", SqlDbType.NVarChar);
            param3.Value = c.address;
            SqlParameter param4 = new SqlParameter("@username", SqlDbType.NVarChar);
            param4.Value = c.username;
            SqlParameter param5 = new SqlParameter("@password", SqlDbType.NVarChar);
            param5.Value = c.password;
            SqlParameter param6 = new SqlParameter("@status", SqlDbType.NVarChar);
            param6.Value = c.status;
            SqlParameter param7 = new SqlParameter("@id", SqlDbType.Int);
            param7.Value = c.customer_id;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5, param6, param7);
                MessageBox.Show("This Customer Is Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }

        }

        public void InsertCustomer(Customer c)
        {
            string sql = @"INSERT INTO [dbo].[customer]
           ([name]
           ,[phone]
           ,[address]
           ,[username]
           ,[password]
           ,[status])
     VALUES
           (@name , @phone , @address , @username , @password , @status)";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = c.name;
            SqlParameter param2 = new SqlParameter("@phone", SqlDbType.NVarChar);
            param2.Value = c.phone;
            SqlParameter param3 = new SqlParameter("@address", SqlDbType.NVarChar);
            param3.Value = c.address;
            SqlParameter param4 = new SqlParameter("@username", SqlDbType.NVarChar);
            param4.Value = c.username;
            SqlParameter param5 = new SqlParameter("@password", SqlDbType.NVarChar);
            param5.Value = c.password;
            SqlParameter param6 = new SqlParameter("@status", SqlDbType.NVarChar);
            param6.Value = c.status;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5, param6);
                MessageBox.Show("A New Customer Is Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }
        }

        public void DeleteCustomer(int Id)
        {
            string sql = @"DELETE FROM [dbo].[customer]
                         WHERE customer_id = @id";
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

        public Boolean Login(Customer a)
        {
            List<Customer> list = new List<Customer>();
            string sql = "SELECT * FROM [customer] WHERE username LIKE '%' + @user + '%' AND password LIKE '%' + @password + '%'";
            SqlParameter parameters = new SqlParameter("@user", SqlDbType.VarChar);
            parameters.Value = a.username;
            SqlParameter parameters1 = new SqlParameter("@password", SqlDbType.VarChar);
            parameters1.Value = a.password;
            DataTable dt = DAO.GetDataBySql(sql, parameters, parameters1);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using Microsoft.Data.SqlClient;
using ProjectPRN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace ProjectPRN.DAL
{
    internal class ProductDAO
    {
        public  List<Product> GetAllProduct()
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM product";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
             
                list.Add(new Product(
                    Convert.ToInt32(dr["product_id"]),
                    dr["product_name"].ToString(),
                    dr["description"].ToString(),
                    dr["image"].ToString(),
                    Convert.ToDouble(dr["list_price"]),
                    Convert.ToDouble(dr["discount"]),
                    dr["category_name"].ToString(),
                    dr["status"].ToString()));
            }
            return list;
        }



        public  List<Product> GetProduct(int id)
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM product WHERE product_id = @id";
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
                    list.Add(new Product(
                        Convert.ToInt32(dr["product_id"]),
                        dr["product_name"].ToString(),
                        dr["description"].ToString(),
                        dr["image"].ToString(),
                        Convert.ToDouble(dr["list_price"]),
                        Convert.ToDouble(dr["discount"]),
                        dr["category_name"].ToString(),
                        dr["status"].ToString()));
                }
                return list;
            }
        }

        public List<String> GetAllCategory()
        {
            List<String> list = new List<String>();
            string sql = "SELECT category_name  FROM product group by category_name ";
            DataTable dt = DAO.GetDataBySql(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(dr["category_name"].ToString());
                }
                return list;
            }
        }

        public List<Product> SearchProductByCategory(string category)
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM product WHERE category_name like '%' + @category + '%' ";
            SqlParameter parameters = new SqlParameter("@category", SqlDbType.NVarChar);
            parameters.Value = category;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Product(
                        Convert.ToInt32(dr["product_id"]),
                        dr["product_name"].ToString(),
                        dr["description"].ToString(),
                        dr["image"].ToString(),
                        Convert.ToDouble(dr["list_price"]),
                        Convert.ToDouble(dr["discount"]),
                        dr["category_name"].ToString(),
                        dr["status"].ToString()));
                }
                return list;
            }
        }


        public int CountAllProduct()
        {
            int n = 0;
            string sql = "SELECT COUNT(product_id) AS count FROM product";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {

                n = Convert.ToInt32(dr["count"]);
            }
            return n;
        }

        public int CountAllProductforCategory(string category)
        {
            int n = 0;
            string sql = "SELECT COUNT(product_id) AS count FROM product where category_name like '%' + @category + '%'";
            SqlParameter parameters = new SqlParameter("@category", SqlDbType.NVarChar);
            parameters.Value = category;
            DataTable dt = DAO.GetDataBySql(sql, parameters);
            foreach (DataRow dr in dt.Rows)
            {
                n = Convert.ToInt32(dr["count"]);
            }
            return n;
        }


        public  List<Product> SearchProductbyName(string name)
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM product WHERE product_name like '%' + @name + '%' ";
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
                    list.Add(new Product(
                        Convert.ToInt32(dr["product_id"]),
                        dr["product_name"].ToString(),
                        dr["description"].ToString(),
                        dr["image"].ToString(),
                        Convert.ToDouble(dr["list_price"]),
                        Convert.ToDouble(dr["discount"]),
                        dr["category_name"].ToString(),
                        dr["status"].ToString()));
                }
                return list;
            }
        }

        public List<Product> SearchProductbyPrice(int from, int to)
        {
            List<Product> list = new List<Product>();
            string sql = "SELECT * FROM product WHERE  list_price >= @from and list_price <= @to";
            SqlParameter parameters = new SqlParameter("@from", SqlDbType.Int);
            parameters.Value = from;
            SqlParameter parameters1 = new SqlParameter("@to", SqlDbType.Int);
            parameters1.Value = to;
            DataTable dt = DAO.GetDataBySql(sql, parameters, parameters1);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Product(
                        Convert.ToInt32(dr["product_id"]),
                        dr["product_name"].ToString(),
                        dr["description"].ToString(),
                        dr["image"].ToString(),
                        Convert.ToDouble(dr["list_price"]),
                        Convert.ToDouble(dr["discount"]),
                        dr["category_name"].ToString(),
                        dr["status"].ToString()));
                }
                return list;
            }
        }

        public void UpdateProduct(Product p)
        {
            string sql = @"UPDATE [dbo].[product]
   SET [product_name] = @name
      ,[description] = @description
      ,[image] = @image
      ,[list_price] = @list_price
      ,[discount] = @discount
      ,[category_name] = @category
      ,[status] = @status
 WHERE product_id = @id ";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
            param1.Value = p.product_name;
            SqlParameter param2 = new SqlParameter("@description", SqlDbType.VarChar);
            param2.Value = p.description;
            SqlParameter param3 = new SqlParameter("@image", SqlDbType.VarChar);
            param3.Value = p.image;
            SqlParameter param4 = new SqlParameter("@list_prices", SqlDbType.Float);
            param4.Value = p.list_price;
            SqlParameter param5 = new SqlParameter("@discount", SqlDbType.Float);
            param5.Value = p.discount;
            SqlParameter param6 = new SqlParameter("@category", SqlDbType.VarChar);
            param6.Value = p.category_name;
            SqlParameter param7 = new SqlParameter("@status", SqlDbType.VarChar);
            param7.Value = p.status;
            SqlParameter param8 = new SqlParameter("@id", SqlDbType.Int);
            param8.Value = p.product_id;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5, param6, param7, param8);
                MessageBox.Show("This Product Is Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }

        }

        public void InsertProduct(Product p)
        {
            string sql = @"INSERT INTO [dbo].[product]
           ([product_name]
           ,[description]
           ,[image]
           ,[list_price]
           ,[discount]
           ,[category_name]
           ,[status])
             VALUES
           (@name,@description,@image,@list_prices,@discount,@category,@status)";

            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
            param1.Value = p.product_name;
            SqlParameter param2 = new SqlParameter("@description", SqlDbType.VarChar);
            param2.Value = p.description;
            SqlParameter param3 = new SqlParameter("@image", SqlDbType.VarChar);
            param3.Value = p.image;
            SqlParameter param4 = new SqlParameter("@list_prices", SqlDbType.Float);
            param4.Value = p.list_price;
            SqlParameter param5 = new SqlParameter("@discount", SqlDbType.Float);
            param5.Value = p.discount;
            SqlParameter param6 = new SqlParameter("@category", SqlDbType.VarChar);
            param6.Value = p.category_name;
            SqlParameter param7 = new SqlParameter("@status", SqlDbType.VarChar);
            param7.Value = p.status;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5, param6, param7);
                MessageBox.Show("A New Product Is Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }

        }

        public void DeleteProduct(int Id)
        {
            string sql = @"DELETE FROM [dbo].[product]
                         WHERE product_id = @id";
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

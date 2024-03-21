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
    internal class AdminDAO
    {
        

        public  List<Admin> GetAllAdmin()
        {
            List<Admin> list = new List<Admin>();
            string sql = "SELECT * FROM admin";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {

                list.Add(new Admin(
                        Convert.ToInt32(dr["admin_id"]),
                        dr["name"].ToString(),
                        dr["phone"].ToString(),
                        dr["username"].ToString(),
                        dr["password"].ToString()));
            }
            return list;
        }
        public  List<Admin> GetAdmin(int id)
        {
            List<Admin> list = new List<Admin>();
            string sql = "SELECT * FROM admin WHERE admin_id = @id";
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
                    list.Add(new Admin(
                    Convert.ToInt32(dr["admin_id"]),
                    dr["name"].ToString(),
                    dr["phone"].ToString(),
                    dr["username"].ToString(),
                    dr["password"].ToString()));
                }
                return list;
            }
        }

        public List<Admin> GetAdminByAccount(Admin ad)
        {
            List<Admin> list = new List<Admin>();
            string sql = "SELECT * FROM admin WHERE username LIKE '%' + @user + '%' AND password LIKE '%' + @password + '%'";
            SqlParameter parameters = new SqlParameter("@user", SqlDbType.VarChar);
            parameters.Value = ad.username;
            SqlParameter parameters1 = new SqlParameter("@password", SqlDbType.VarChar);
            parameters1.Value = ad.password;
            DataTable dt = DAO.GetDataBySql(sql, parameters, parameters1);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new Admin(
                    Convert.ToInt32(dr["admin_id"]),
                    dr["name"].ToString(),
                    dr["phone"].ToString(),
                    dr["username"].ToString(),
                    dr["password"].ToString()));
                }
                return list;
            }
        }

        public  List<Admin> SearchAdminbyName(string name)
        {
            List<Admin> list = new List<Admin>();
            string sql = "SELECT * FROM admin WHERE name like '%' + @name + '%' ";
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
                    list.Add(new Admin(
                    Convert.ToInt32(dr["admin_id"]),
                    dr["name"].ToString(),
                    dr["phone"].ToString(),
                    dr["username"].ToString(),
                    dr["password"].ToString()));
                }
                return list;
            }
        }

        public void UpdateAdmin(Admin a)
        {
            string sql = @"UPDATE [dbo].[admin]
            SET [name] = @name
            ,[phone] = @phone
            ,[username] = @username
            ,[password] = @password
            WHERE admin_id = @id";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = a.name;
            SqlParameter param2 = new SqlParameter("@phone", SqlDbType.NVarChar);
            param2.Value = a.phone;
            SqlParameter param3 = new SqlParameter("@username", SqlDbType.NVarChar);
            param3.Value = a.username;
            SqlParameter param4 = new SqlParameter("@password", SqlDbType.NVarChar);
            param4.Value = a.password;
            SqlParameter param5 = new SqlParameter("@id", SqlDbType.Int);
            param5.Value = a.admin_id;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4, param5);
                MessageBox.Show("This Admin Is Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }

        }

        public void InsertAdmin(Admin a)
        {
            string sql = @"INSERT INTO [dbo].[admin]
           ([name]
           ,[phone]
           ,[username]
           ,[password])
            VALUES
           (@name,@phone,@username,@password)";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
            param1.Value = a.name;
            SqlParameter param2 = new SqlParameter("@phone", SqlDbType.VarChar);
            param2.Value = a.phone;
            SqlParameter param3 = new SqlParameter("@username", SqlDbType.VarChar);
            param3.Value = a.username;
            SqlParameter param4 = new SqlParameter("@password", SqlDbType.VarChar);
            param4.Value = a.password;
            try
            {
                DAO.ExecuteSQL(sql, param1, param2, param3, param4);
                MessageBox.Show("A New Admin Is Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Note:" + ex);
            }
        }

        public void DeleteAdmin(int Id)
        {
            string sql = @"DELETE FROM [dbo].[admin]
                         WHERE admin_id = @id";
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

        public Boolean Login(Admin a)
        {
            List<Admin> list = new List<Admin>();
            string sql = "SELECT * FROM [admin] WHERE username LIKE '%' + @user + '%' AND password LIKE '%' + @password + '%'";
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

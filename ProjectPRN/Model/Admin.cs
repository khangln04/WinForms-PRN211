using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPRN.Model
{
    internal class Admin
    {
        public int admin_id { get; set; }
        public string name { get; set; }

        public string phone { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public Admin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Admin(int admin_id, string name, string phone, string username, string password)
        {
            this.admin_id = admin_id;
            this.name = name;
            this.phone = phone;
            this.username = username;
            this.password = password;
        }
    }
    internal static class SessionDataAdmin
    {
        public static List<Admin> Admin { get; set; } = new List<Admin>();
    }
}

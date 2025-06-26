using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Rashidova
{
    public class Admin
    {
        public string Role { get; set; }

        public Admin(string role)
        {
            Role = role;
        }

        public bool ManageUsers(string[] users)
        {
            return users != null && users.Length > 0;
        }
    }
}

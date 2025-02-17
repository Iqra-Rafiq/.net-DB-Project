using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectfinal.BL
{
   public  class Users
    {
        public string name;
        public string password;
        public string role;
        public int phonenumber;
        public string age;
        public string email;
        public string Name
        {
            get => name; set => name = value;
        }
        public string Password
        {
            get => password; set => password = value;
        }
        public string Role
        {
            get => role; set => role = value;
        }
        public Users(string name,string password,string role, string email, int phonenumber, string age)
        {
            this.password = password;
            this.role = role;
            this.name = name;
            this.email = email;
            this.age = age;
            this.phonenumber = phonenumber;
        }
       
        public Users()
        {
        }
        public Users(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public Users(string name, string password,string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public bool isAdmin(Users u)
        {
            if (u.role == "Admin " || u.role == "admin")
            {
                return true;
            }
            return false;
        }
    }
}

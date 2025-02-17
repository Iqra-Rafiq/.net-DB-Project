using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectfinal.DL;
using Projectfinal.BL;
using System.IO;

namespace Projectfinal.DL
{
    public class UsersDL
    {
        public static List<Users> userslist = new List<Users>();

        internal List<Users> Userslist
        {
            get => userslist; set => userslist = value;
        }

        public static string returnRoles(Users user)
        {
            foreach (var u in userslist)
            {
                if (user.Name == u.Name && user.Password == u.Password)
                {
                    return u.Role;
                }
            }
            return null;
        }
        public static void addToList(Users user)
        {
            userslist.Add(user);
        }
        public static void storeUsers(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            foreach (var u in userslist)
            {
                f1.WriteLine(u.Name + "," + u.Password + "," + u.Role);
            }
            f1.Flush();
            f1.Close();
        }
        public static bool loadUsers(string path)
        {
            string record;
            StreamReader f1 = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f1.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    string name = splittedrecord[0];
                    string password = (splittedrecord[1]);
                    string role = (splittedrecord[2]);
                    Users u = new Users(name, password, role);
                    addToList(u);

                }
                f1.Close();
                return true;
            }
            return false;
        }
        public static void deleteFromList(Users user)
        {
            for (int i = 0; i < userslist.Count; i++)
            {
                if (userslist[i].Name == user.Name && userslist[i].Password == user.Password)
                {
                    userslist.RemoveAt(i);
                }
            }
        }
        public static void editFromList(Users previoususer, Users updated)
        {
            foreach (var user in userslist)
            {
                if (user.Name == previoususer.Name && user.Password == previoususer.Password)
                {
                    user.Name = updated.Name;
                    user.Password = updated.Password;
                    user.Role = updated.Role;
                }
            }

        }
    }
}

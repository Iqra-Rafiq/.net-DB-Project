using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projectfinal.DL;
using Projectfinal.BL;
using System.Drawing;
using System.Windows.Forms;

namespace Projectfinal.DL
{
     public class CustomerDL
    {
        public static List<Customers> customerslist = new List<Customers>();
        public static void addtolist(Customers c)
        {
            customerslist.Add(c);
        }
        public static void storeCustomers(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            foreach (var u in customerslist)
            {
                f1.WriteLine(u.Name +","+u.password+","+u.role+ "," + u.email + "," +u.phonenumber+"," + u.age + "," + u.Province);
            }
            f1.Flush();
            f1.Close();
        }
        public static int searchCustomer(string name)
        {
            for(int i=0; i<customerslist.Count; i++)
            {
                if (customerslist[i].name == name)
                {
                    return i;
                }
            }
            return -1;
        }
        public static Customers search(string name)
        {
            for (int i = 0; i < customerslist.Count; i++)
            {
                if (customerslist[i].name == name)
                {
                    return customerslist[i];
                }
            }
            return null;
        }

        public static bool loadProducts(string path)
        {

            StreamReader f1 = new StreamReader(path);
            string line;
            if (File.Exists(path))
            {
                while ((line = f1.ReadLine()) != null)
                {

                    string name = getField(line, 1);
                    string category = getField(line, 2);
                    string quantity = getField(line, 3);
                    string price = getField(line, 4);
                    Products p = new Products(name, category, int.Parse(quantity), double.Parse(price));
                    SignInform.C1.Buyproduct.Add(p);
                }
                f1.Close();
                return true;
            }

            return false;

        }
        public static string getField(string record, int field)
        {
            int commacount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commacount++;
                }
                else if (commacount == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool loadCustomers(string path)
        {
            string record;
            StreamReader f1 = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f1.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    string name = splittedrecord[0];
                    string pswrd = splittedrecord[1];
                    string role = "Customer";
                    string email = splittedrecord[3];
                    string phonenumber = splittedrecord[4];
                    string age = splittedrecord[5];
                    string province = splittedrecord[6];
                    Customers c = new Customers(name,pswrd,role, email, int.Parse(phonenumber), age, province);
                    CustomerDL.addtolist(c);

                }
                f1.Close();
                return true;
            }
            return false;
        }
        public static int returnindex(string name)
        {
            for(int i=0; i<customerslist.Count; i++)
            {
                if (customerslist[i].name == name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

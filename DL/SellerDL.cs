using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projectfinal.BL;
using Projectfinal.DL;
namespace Projectfinal.DL
{
   public class SellerDL
    {
       
        private static List<Sellers> sellerslist = new List<Sellers>();
        private static List<string> soldproductlist = new List<string>();
        internal static List<Sellers> Sellerslist
        {
            get => sellerslist;
            set => sellerslist = value;
        }
        public static int getCountofSoldProducts()
        {
            return soldproductlist.Count;
        }
        public static List<string> Soldproductlist { get => soldproductlist; set => soldproductlist = value; }

        public static void addtoList(Sellers s)
        {
            sellerslist.Add(s);
        }
        public static void storeSellers(string path)
        {

            StreamWriter f1 = new StreamWriter(path, true);
            foreach (var u in sellerslist)
            {
                f1.WriteLine(u.Name + "," +u.password+","+ u.role+","+u.email + "," + u.phonenumber + "," + u.Age + "," + u.Idcardnumber);
            }
            f1.Flush();
            f1.Close();
        }
        public static bool loadSellers(string path)
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
                    string role = "Seller";
                    string email = splittedrecord[3];
                    string phonenumber = splittedrecord[4];
                    string age = splittedrecord[5];
                    string idcard = splittedrecord[6];
                    Sellers s = new Sellers(name,pswrd,role, email, int.Parse(phonenumber), age, idcard);
                    addtoList(s);

                }
                f1.Close();
                return true;
            }
            return false;
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
                    string path1 = getField(line, 5);
                    Image img = new Bitmap(path1);
                    Products p = new Products(name, category, int.Parse(quantity), double.Parse(price), path1, img);
                    SignInform.S1.addproduct.Add(p);
                }
                f1.Close();
                return true;
            }

            return false;

        }
        public static void addsoldproductToList(string name)
        {
            Soldproductlist.Add(name);
        }
        public static void storeSoldProducts(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            for (int i = 0; i < soldproductlist.Count; i++)
            {
                f1.WriteLine(soldproductlist[i]);
            }
            f1.Flush();
            f1.Close();
        }
        public static bool loadSoldProducts(string path)
        {


            string line;
            if (File.Exists(path))
            {

                StreamReader f1 = new StreamReader(path);
                string name = f1.ReadLine();
                SellerDL.addsoldproductToList(name);

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

        public static Sellers searchSeller(string name)
        {
            for (int i = 0; i < sellerslist.Count; i++)
            {

                if (Sellerslist[i].name == name)
                {

                    return Sellerslist[i];
                }
            }
            return null;
        }
        public static void deleteFromList(Products p,Sellers s)
        {
            for (int i = 0; i < s.addproduct.Count; i++)
            {
                if (s.addproduct[i].Productname == p.Productname)
                {
                    s.addproduct.RemoveAt(i);
                }
            }
        }
        /* public static bool loadSoldProducts(string path)
       *//*  {
             string record;
             StreamReader f1 = new StreamReader(path);
             if (File.Exists(path))
             {
                 while ((record = f1.ReadLine()) != null)
                 {
                     string[] splittedrecord = record.Split(',');
                     string name = splittedrecord[0];
                     addsoldproductToList(name);
                 }
                 f1.Close();
                 return true;
             }
             return false;
         }*/
    }
}

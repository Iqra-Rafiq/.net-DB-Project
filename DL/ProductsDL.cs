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
    public class ProductsDL
    {
        private static List<Products> productslist = new List<Products>();
        private static List<Products> custproductslist = new List<Products>();

        public static List<Products> Productslist { get => productslist; set => productslist = value; }
        public static List<Products> Custproductslist { get => custproductslist; set => custproductslist = value; }

        public static void addtoList(Products p)
        {
            Productslist.Add(p);
        }
        public static void custaddtoList(Products p)
        {
            custproductslist.Add(p);
        }
        public static void storeProducts(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            for (int i = 0; i < productslist.Count; i++)
            {
                {
                    f1.WriteLine(productslist[i].Productname + "," + productslist[i].Category + "," + productslist[i].Quantity + "," + productslist[i].Price + "," + productslist[i].Picturename + "," + productslist[i].S);
                }
            }
            f1.Flush();
            f1.Close();
        }
        public static void custstoreProducts(string path)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            for (int i = 0; i < custproductslist.Count; i++)
            {
                {
                    f1.WriteLine(custproductslist[i].Productname + "," + custproductslist[i].Category + "," + custproductslist[i].Quantity + "," + custproductslist[i].Price + "," + custproductslist[i].S +","+ custproductslist[i].Province);
                }
            }
            f1.Flush();
            f1.Close();
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
                    string id = getField(line, 6);
                    Products p = new Products(name, category, int.Parse(quantity), double.Parse(price), path1, img, id);
                    productslist.Add(p);
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
        public static bool custloadProducts(string path)
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
                    string id = getField(line, 5);
                    string custname = getField(line, 6);
                    Products p = new Products(name, category, int.Parse(quantity), double.Parse(price), id, custname);
                    custproductslist.Add(p);
                }
                f1.Close();
                return true;
            }
            return false;
        }
            public static int searchProduct(string name)
            {
                for (int i = 0; i < Productslist.Count; i++)
                {
                    if (productslist[i].Productname == name)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public static void deleteFromList(Products p)
            {
                for (int i = 0; i < productslist.Count; i++)
                {
                    if (productslist[i].Productname == p.Productname)
                    {
                        productslist.RemoveAt(i);
                    }
                }
            }
            public static void editFromList(Products previousproduct, Products updated)
            {
                foreach (var product in productslist)
                {
                    if (product.Productname == previousproduct.Productname)
                    {
                        product.Productname = updated.Productname;
                        product.Quantity = updated.Quantity;
                        product.Price = updated.Price;
                        product.Category = updated.Category;
                    }
                }
            }
        }
    }

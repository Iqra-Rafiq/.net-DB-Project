using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectfinal.BL
{
   public class Customers:Users
    {
        private List<Products> buyproduct;
        private string province;
        private Deliverycharges cityinfo;
        private List<string> wishlist;
        internal List<Products> Buyproduct
        {
            get => buyproduct; set => buyproduct = value;
        }
      public void addtowishList(string product)
        {
            Wishlist.Add(product);
        }
        public string Province { get => province; set => province = value; }
        public List<string> Wishlist { get => wishlist; set => wishlist = value; }

        public void addtoList(Products p)
        {
            buyproduct.Add(p);

        }

        public void storeProducts(string path, Customers c)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            for (int i = 0; i < c.Buyproduct.Count; i++)
            {
                {
                    f1.WriteLine(c.Buyproduct[i].Productname + "," + c.Buyproduct[i].Category + "," + c.Buyproduct[i].Quantity + "," + c.Buyproduct[i].Price);
                }
            }
            f1.Flush();
            f1.Close();
        }

        public Customers(string name,string pswrd,string role, string email, int phonenumber, string age, string province) : base(name,pswrd, role, email, phonenumber, age)
        {
            wishlist = new List<string>();
            buyproduct = new List<Products>();
            wishlist = new List<string>();
            cityinfo = new Deliverycharges();
            this.province = province;

        }
    }
}

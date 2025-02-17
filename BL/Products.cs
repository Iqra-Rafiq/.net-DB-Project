using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectfinal.BL
{
    public class Products
    {
        private string productname;
        private string category;
        private int quantity;
        private double price;
        private string picturename;
        private Image img;
        private string s;
        private string province;

        public Products(string productname, string category, int quantity, double price, string id, string province)
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.price = price;
            this.S = id;
            this.province = province;


        }
        public Products(string productname, string category, int quantity, double price, string picturename, Image img, string id)
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.price = price;
            this.picturename = picturename;
            this.Img = img;
            S = id;
        }

        public Products(string productname, string category, int quantity, double price, string picturename, Image img)
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.price = price;
            this.picturename = picturename;
            this.Img = img;
        }

        public Products(string productname, string category, int quantity, double price,string id) 
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.price = price;
            this.S = id;

        }

        public Products(string productname, string category, int quantity, double price)
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
            this.category = category;
            this.price = price;


        }

        public Image Img { get => img; set => img = value; }
        public string Productname { get => productname; set => productname = value; }
        public string Category { get => category; set => category = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string Picturename { get => picturename; set => picturename = value; }
        public string S { get => s; set => s = value; }
        public string Province { get => province; set => province = value; }

        /* public Image Img { get => img; set => img = value; }*/
    }
}

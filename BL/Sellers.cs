using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectfinal.BL
{
    public class Sellers:Users
    {
        private string idcardnumber;
        public List<Products> addproduct;
        public Sellers(string name,string pswrd,string role, string email, int phonenumber, string age, string idcardnumber) : base(name,pswrd,role,email, phonenumber, age)
        {
            this.Idcardnumber = idcardnumber;
             addproduct = new List<Products>();
         }

        public Sellers(string idcardnumber) 
        {
            this.Idcardnumber = idcardnumber;
            
        }

        public void storeProducts(string path,Sellers s)
        {

            StreamWriter f1 = new StreamWriter(path, false);
            for (int i = 0; i < s.addproduct.Count; i++)
            {
                {
                    f1.WriteLine(s.addproduct[i].Productname + "," + s.addproduct[i].Category + "," + s.addproduct[i].Quantity + "," + s.addproduct[i].Price + "," + s.addproduct[i].Picturename);
                }
            }
            f1.Flush();
            f1.Close();
        }

        public string Age { get => age; set => age = value; }
        public string Idcardnumber { get => idcardnumber; set => idcardnumber = value; }
    }
}

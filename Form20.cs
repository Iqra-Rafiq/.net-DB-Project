using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projectfinal.DL;
using Projectfinal.BL;
namespace Projectfinal
{
    public partial class Billform : Form
    { public double bill;
        public int idx;
        public Billform(int index)
        {
            InitializeComponent();
            idx = index;
        }

        private void lbltotalprice_Click(object sender, EventArgs e)
        {

        }

        private void Form20_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SignInform.C1.Buyproduct.Count; i++)
            {
                bill = SignInform.C1.Buyproduct[i].Price + bill;
            }
            SellerDL.storeSoldProducts("soldproducts.txt");

            //ProductsDL.storeProducts("products.txt");
            lbltotalprice.Text = bill.ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CustomersMenuform c = new CustomersMenuform(idx);
            c.Show();
            this.Close();

        }

        private void lblbill_Click(object sender, EventArgs e)
        {

        }
    }
}

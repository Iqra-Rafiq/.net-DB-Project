using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projectfinal.BL;
using Projectfinal.DL;
namespace Projectfinal
{
    public partial class SignUpSeller : Form
    {
        public SignUpSeller()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                Sellers s = new Sellers(txtname.Text, txtpwd.Text, "Seller", txtemail.Text, int.Parse(txtphonenumber.Text), dateTimePicker1.Text, txtid.Text);
                SellerDL.addtoList(s);
                Users u = new Users(txtname.Text, txtpwd.Text, "Seller");
                UsersDL.addToList(u);
                SellerDL.addtoList(s);
                UsersDL.storeUsers("users.txt");
                UsersDL.addToList(s);
                SellerDL.storeSellers("sellers.txt");
                MessageBox.Show("Signup Completed ");
                AdminMenuform a = new AdminMenuform();
                a.Show();
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, MessageBoxIcon.Warning.ToString());
            }
        }


        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

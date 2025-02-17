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
    public partial class SignUpCustomer : Form
    {
        public SignUpCustomer()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if ((txtemail.Text != "" && txtphonenumber.Text != "" && dateTimePicker1.Value != null && (rdnfemale.Checked || rdnmale.Checked) && textBox1.Text != ""))
            {
                Customers s = new Customers(txtname.Text,txtpwd.Text,"Customer", txtemail.Text, int.Parse(txtphonenumber.Text), dateTimePicker1.Text, textBox1.Text);
                Users u = new Users(txtname.Text, txtpwd.Text, "Customer");
                UsersDL.addToList(u);
                CustomerDL.addtolist(s);
                UsersDL.storeUsers("users.txt");
                CustomerDL.storeCustomers("customers.txt");
                this.Close();
                CaptchaCustomer c1 = new CaptchaCustomer();
                c1.Show();
            }
            else
            {
                MessageBox.Show("Fill form Completely");
            }
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void comboprovince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

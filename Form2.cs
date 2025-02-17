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
    public partial class viewcustomerforms : Form
    {
        public viewcustomerforms()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            /*
            if (txtname.Text != "" && txtpwd.Text != "")
            {
           Customers user = new Customers(txtname.Text, txtpwd.Text, "Customer");
            DL.UsersDL.addToList(user);
            DL.UsersDL.storeUsers("users.txt");
            MessageBox.Show("Your account has been created ", "Save");
            this.Close();
            Form3 customer = new Form3();
            customer.Show();
            }
            else
            {
                MessageBox.Show("Complete SignUp");
            }

        */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerDL.customerslist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (SignInform.u == "Admin")
            {
                AdminMenuform f = new AdminMenuform();
                f.Show();
                this.Close();
            }
            else
            {
                SellerMenuform f = new SellerMenuform();
                f.Show();
                this.Close();
            }

        }
    }
}

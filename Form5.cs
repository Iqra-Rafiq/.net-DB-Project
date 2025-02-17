using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectfinal
{
    public partial class AdminMenuform : Form
    {
        public AdminMenuform()
        {
            InitializeComponent();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnaddsellers_Click(object sender, EventArgs e)
        {
            SignUpSeller seller = new SignUpSeller();
            seller.ShowDialog();
            this.Close();
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CustomerViewform viewUsers = new CustomerViewform();
            viewUsers.Show();
            this.Close();

        }

        private void btnsoldproducts_Click(object sender, EventArgs e)
        {
            Soldproductsform s = new Soldproductsform();
            s.Show();
            this.Close();
        }

        private void btnviewcustomers_Click(object sender, EventArgs e)
        {
            viewcustomerforms v = new viewcustomerforms();
            v.Show();
            this.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close()
;        }

        private void btnviewproducts_Click(object sender, EventArgs e)
        {
            Productsviewform p = new Productsviewform();
            p.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Riders o = new Riders();
            o.Show();
            this.Close();
        }
    }
}

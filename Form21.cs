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
    public partial class Soldproductsform : Form
    {
        public Soldproductsform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form21_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SellerDL.Soldproductlist;
            
            dataGridView1.Columns[0].HeaderText = "Sold Products";
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


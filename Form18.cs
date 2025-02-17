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
    public partial class Wishlistform : Form
    {
        public int idx;
        public Wishlistform(int index)
        {
            InitializeComponent();
            idx = index;
        }
        
        private void Form18_Load(object sender, EventArgs e)
        {
            if (SignInform.C1.Wishlist.Count != 0)
            {
                MessageBox.Show(SignInform.C1.Wishlist[0]);
                //dataGridView1.Columns[0].HeaderText = "WishList Items";

                dataGridView1.DataSource = SignInform.C1.Wishlist;

            }
            else
            {
                dataGridView1.Visible = false;
                pictureBox3.Visible = true;
            }
            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CustomersMenuform f = new CustomersMenuform(idx);
            f.Show();
            this.Close();
        }
    }
}

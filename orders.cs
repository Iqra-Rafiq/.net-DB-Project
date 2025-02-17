using Projectfinal.BL;
using Projectfinal.DL;
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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orders_Load(object sender, EventArgs e)
        {
            List<Products> p = new List<Products>();
            foreach (var a in ProductsDL.Custproductslist)
            {
                if (a.S == SignInform.S1.Idcardnumber)
                {

                    Products p1 = new Products(a.Productname, a.Category, a.Quantity, a.Price, a.S, a.Province);
                    p.Add(p1);
                }
            }
            
            dataGridView1.DataSource = p;
            this.dataGridView1.Columns["Img"].Visible = false;
            this.dataGridView1.Columns["S"].Visible = false;
            this.dataGridView1.Columns["Picturename"].Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            SellerMenuform S = new SellerMenuform();
            S.Show();
            
        }
    }
}

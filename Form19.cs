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
    public partial class ViewCartform : Form
    {
        public int idx;
        public ViewCartform(int index)
        {
            InitializeComponent();
            idx = index;

        }

        private void Form19_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SignInform.C1.Buyproduct;
            this.dataGridView1.Columns["Img"].Visible = false;
            this.dataGridView1.Columns["S"].Visible = false;
            this.dataGridView1.Columns["Picturename"].Visible = false;
            this.dataGridView1.Columns["custname"].Visible = false;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

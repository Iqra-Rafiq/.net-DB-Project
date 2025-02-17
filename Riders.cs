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
    public partial class Riders : Form
    {
       
        public Riders()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminMenuform S = new AdminMenuform();
            S.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rider R = new Rider(richTextBox1.Text,"true");
            RiderDL.addtoList(R);
            RiderDL.storeRiders("rider.txt");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Riders_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RiderDL.Riders1;
        }
    }
}

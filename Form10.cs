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
    public partial class SellerMenuform : Form
    {
        public int index;
        public SellerMenuform()
        {
            InitializeComponent();
            
        }
        public SellerMenuform(int i)
        {
            InitializeComponent();
            index = i;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productsviewform p = new Productsviewform();
            p.Show();
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productentryform f = new Productentryform();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Productsviewform f = new Productsviewform();
            f.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chargesentryform f = new Chargesentryform();
            f.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Soldproductsform f = new Soldproductsform();
            f.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewcustomerforms c = new viewcustomerforms();
            c.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            orders a = new orders();
            a.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Riders a = new Riders();
            a.Show();
            this.Close();
        }
    }
}

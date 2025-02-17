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
    public partial class Chargesentryform : Form
    {
        public Chargesentryform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Deliverycharges d = new Deliverycharges(comboBox1.Text, int.Parse(txtcharges.Text));
                DeliveryChargesDL.addtolist(d);
                DeliveryChargesDL.storeCharges("charges.txt");
                MessageBox.Show("Charges added Successfully");
                SellerMenuform s = new SellerMenuform();
                s.Show();
                this.Close();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, MessageBoxIcon.Warning.ToString());    
            }
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}

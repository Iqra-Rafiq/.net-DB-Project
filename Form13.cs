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
    public partial class Productseditform : Form
    {
        private Products previous;
        public Productseditform(Products previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
     

        private void Form13_Load(object sender, EventArgs e)
        {
          txtquantity.Text = previous.Quantity.ToString();
            txtprice.Text = previous.Price.ToString();
          
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Products updated = new Products(previous.Productname,previous.Category,int.Parse(txtquantity.Text), double.Parse(txtprice.Text));
            ProductsDL.editFromList(previous, updated);
            MessageBox.Show("Product Edited Successfully");
            this.Close();
        }
    }
    }


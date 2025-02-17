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
    public partial class Accountdetails : Form
    {
        public int index;
        public Accountdetails(int idx)
        {
            InitializeComponent();
            index = idx;
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            lblemail2.Text = CustomerDL.customerslist[index].email;
            lblname2.Text = CustomerDL.customerslist[index].name;
            lblphone2.Text = CustomerDL.customerslist[index].phonenumber.ToString();
            lblprovince2.Text = CustomerDL.customerslist[index].Province;
            lblprovince2.Visible = true;
            lblphone2.Visible = true;
            lblemail2.Visible = true;
            lblname2.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CustomersMenuform f = new CustomersMenuform(index);
            f.Show();
             this.Close();
        
        }
    }
}

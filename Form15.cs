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
    public partial class CustomersMenuform : Form
    {
        public int index;
       
        public CustomersMenuform(int i )
        {
            InitializeComponent();
            index = i;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void Form15_Load(object sender, EventArgs e)
        {
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Orderform f = new Orderform(index);
            f.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Accountdetails f = new Accountdetails(index);
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wishlistform f = new Wishlistform(index);
            f.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewCartform f = new ViewCartform(index);
            f.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billform f = new Billform(index);
            f.Show();
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
    /*  private void databind()
      {
          dataGridView1.DataSource = null;
          dataGridView1.DataSource = UsersDL.userslist;
          dataGridView1.Refresh();
      }
    
      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
          Users user = (Users)dataGridView1.CurrentRow.DataBoundItem;
          if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
          {
              UsersDL.deleteFromList(user);
              UsersDL.storeUsers("users.txt");
              databind();
          }
          if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
          {
              Form9 edit = new Form9(user);
              edit.ShowDialog();
              UsersDL.storeUsers("users.txt");
              databind();
          }*/
}

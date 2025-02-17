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
    public partial class CustomerViewform : Form
    {
        public CustomerViewform()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UsersDL.userslist;
        }
        private void databind()
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
                EditUsersform edit = new EditUsersform(user);
                edit.ShowDialog();
                UsersDL.storeUsers("users.txt");
                databind();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminMenuform a = new AdminMenuform();
            a.Show();
            this.Close();
        }
    }
}


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
    public partial class EditUsersform : Form
    {
        private Users previous;
        public EditUsersform(Users previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users updated = new Users(txtname.Text, txtpwd.Text, txtrole.Text);
            UsersDL.editFromList(previous, updated);
            MessageBox.Show("User Edited Successfully");
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            txtname.Text = previous.Name;
            txtpwd.Text = previous.Password;
            txtrole.Text = previous.Role;
        }
    }
}

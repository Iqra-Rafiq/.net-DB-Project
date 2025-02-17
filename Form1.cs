using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projectfinal.BL;
using Projectfinal.DL;
namespace Projectfinal
{
    public partial class SignInform : Form
    {
        public bool isbutton_Clicked = false;
        string path = "users.txt";
        public static string u;
        private static Customers c1;
        private static Sellers s1;

        public static Customers C1 { get => c1; set => c1 = value; }
        public static Sellers S1 { get => s1; set => s1 = value; }

        public SignInform()
        {
            InitializeComponent();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            buttoncolor();
            try
            {
                Users user = new Users(txtusername.Text, txtpassword.Text);
                u = DL.UsersDL.returnRoles(user);

                if (u != null)
                {
                    MessageBox.Show("Valid User");
                    if (u == "Admin")
                    {
                        AdminMenuform admin = new AdminMenuform();
                        admin.Show();
                    }
                    else if (u == "Seller")
                    {
                        s1 = SellerDL.searchSeller(user.name);
                        if (File.Exists($"products{S1.name}.txt"))
                        {
                            SellerDL.loadProducts($"products{S1.name}.txt");
                        }
                        
                        SellerMenuform f = new SellerMenuform();
                        f.Show();
                        



                    }
                    else if (u == "Customer")
                    {
                        C1 = CustomerDL.search(user.name);
                        if (File.Exists($"products{C1.name}.txt"))
                        {
                            CustomerDL.loadProducts($"products{C1.name}.txt");
                        }
                        CustomersMenuform c = new CustomersMenuform(CustomerDL.searchCustomer(user.name));
                        
                        c.Show();

                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, MessageBoxIcon.Warning.ToString());
            }
        }
      
        private void buttoncolor()
        {

            if (isbutton_Clicked)
            {
                btnlogin.BackColor = Color.DarkSeaGreen;
            }
            else
            {
                btnlogin.BackColor = Color.Green;

            }
            isbutton_Clicked = !isbutton_Clicked;
        }

        private void btnewaccount_Click(object sender, EventArgs e)
        {
            SignUpCustomer signup = new SignUpCustomer();
            signup.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (UsersDL.loadUsers(path))
            {
                MessageBox.Show("Users Loaded Successfully ");
            }
            else
            {
                MessageBox.Show("Users not loaded.");
            }
        }
    }
}
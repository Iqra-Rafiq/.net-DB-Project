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
    public partial class Productentryform : Form
    {
        public Productentryform()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            txtfile.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //File.Copy(txtfile.Text, Path.Combine(@"C:\Users\pakne\OneDrive\programmingday\games\assets", Path.GetFileName(txtfile.Text)), true);
                string path = txtfile.Text;
                MessageBox.Show("Image saved Successfully");
                Image img = Image.FromFile(path);
                if (int.Parse(txtquantity.Text) > 0)
                {
                    Products p = new Products(txtname.Text, txtcategory.Text, int.Parse(txtquantity.Text), double.Parse(txtprice.Text), path,img,SignInform.S1.Idcardnumber);
                    ProductsDL.addtoList(p);
                    SignInform.S1.addproduct.Add(p);
                    SignInform.S1.storeProducts($"products{SignInform.S1.name}.txt",SignInform.S1);
                    ProductsDL.storeProducts("products.txt");
                    this.Close();
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, MessageBoxIcon.Warning.ToString());
            }

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
           
            open.Filter = "Image Files(*.jpg;*jpeg;*gif;*bmp;)|*.jpg;*jpeg;*gif;*bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {             
                txtfile.Text = open.FileName;
                picboxproduct.Image = new Bitmap(open.FileName);
              
            }
        }

        private void picboxproduct_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfile_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

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
    public partial class Orderform : Form
    {
        public bool ischecked = false;
        public int index;
        public int a;
        public Orderform(int idx)
        {
            InitializeComponent();
            index = idx;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
          
            dataGridView1.DataSource = ProductsDL.Productslist;
      
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Products user = (Products)dataGridView1.CurrentRow.DataBoundItem;
            int i = ProductsDL.searchProduct(user.Productname);
            int quantity = user.Quantity;
            a = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow slect = dataGridView1.Rows[a];
            string c = Convert.ToString(slect.Cells["EnterQuantity"].Value);
            //var c = slect.Cells["EnterQuantity"].Value;
            string d = Convert.ToString(slect.Cells["Quantity"].Value);
            try
            {
                if (dataGridView1.Columns["AddtoCart"].Index == e.ColumnIndex)
                {
                    if (int.Parse(c) <= quantity && int.Parse(c) > 0)
                    {
                        Products p1 = new Products(user.Productname, user.Category, int.Parse(c), user.Price * int.Parse(c), ProductsDL.Productslist[i].S);
                        Products p2 = new Products(user.Productname, user.Category, int.Parse(c), user.Price * int.Parse(c), ProductsDL.Productslist[i].S,SignInform.C1.Province);
                        SignInform.C1.addtoList(p1);
                        ProductsDL.custaddtoList(p2);
                        ProductsDL.custstoreProducts("custproducts.txt");
                        ProductsDL.Productslist[i].Quantity = ProductsDL.Productslist[i].Quantity - int.Parse(c);
                        slect.Cells["TotalPrice"].Value = int.Parse(c) * user.Price;
                        SellerDL.addsoldproductToList(user.Productname);
                        MessageBox.Show("Product Added to  Cart ");
                        int f = int.Parse(d);
                        f = f - int.Parse(c);
                        d = f.ToString();
                        slect.Cells["Quantity"].Value = d;
                        SignInform.C1.storeProducts($"products{SignInform.C1.name}.txt", SignInform.C1);
                        MessageBox.Show(SignInform.C1.Province);
                       

                    }

                    else if (int.Parse(c) > quantity && dataGridView1.Columns["AddtoCart"].Index == e.ColumnIndex && int.Parse(c) > 0)
                    {
                        MessageBox.Show("Add Quantity upto " + quantity);
                    }
                }
                if (dataGridView1.Columns["AddtoWishList"].Index == e.ColumnIndex)
                {
                    SignInform.C1.addtowishList(user.Productname);
                    MessageBox.Show("Product is Added to WishList");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, MessageBoxIcon.Warning.ToString());
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnback_Click_2(object sender, EventArgs e)
        {
            CustomersMenuform f = new CustomersMenuform(index);
            f.Show();
            this.Close();
        }

        private void btnback_Click_3(object sender, EventArgs e)
        {
            CustomersMenuform c = new CustomersMenuform(index);
            c.Show();
            this.Close();
        }
    }
    }


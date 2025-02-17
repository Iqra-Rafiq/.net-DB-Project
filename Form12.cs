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
using System.IO;

namespace Projectfinal
{
    public partial class Productsviewform : Form
    {
        public Productsviewform()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

           
            dataGridView1.DataSource = SignInform.S1.addproduct;
         /*   Image img = Image.FromFile(ProductsDL.Productslist[0].Picturename);

            *//* DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
             imgCol.HeaderText = "Photo";
             imgCol.Name = "Photo";
             Products p = new Products("df", img);*/
            /*    dataGridView1.Columns.Add(imgCol);*//*
    
            Object row = new Object[] { "sd", img };
            dataGridView1.Rows.Add(row);

            *//* Products p = new Products("gd", img);
             dataGridView1.Rows.Add(p);*//*
            pictureBox2.Image = img;*/

        }
        private void databind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = SignInform.S1.addproduct;
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
               Products p= (Products)dataGridView1.CurrentRow.DataBoundItem;
                if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
                {
                        SellerDL.deleteFromList(p, SignInform.S1);
                        SignInform.S1.storeProducts($"products{SignInform.S1.name}.txt", SignInform.S1);
                        databind();
                }
                if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
                {
                    Productseditform edit = new Productseditform(p);
                    edit.ShowDialog();
                    SignInform.S1.storeProducts($"products{SignInform.S1.name}.txt", SignInform.S1);
                databind();
                }
            }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (SignInform.u == "Admin")
            {
                AdminMenuform f = new AdminMenuform();
                f.Show();
                this.Close();
            }
            else
            {
                SellerMenuform f = new SellerMenuform();
                f.Show();
                this.Close();
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
        }
 


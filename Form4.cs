using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectfinal
{
    public partial class CaptchaCustomer : Form
    {
        public CaptchaCustomer()
        {
            InitializeComponent();
            loadcaptachaimage();
        }
        int number = 0;
        private void loadcaptachaimage()
        {
            Random r1 = new Random();
            number = r1.Next(1000, 10000);
            var image = new Bitmap(picboxcaptcha.Width, this.picboxcaptcha.Height);
            var font = new Font("Monogram Beta Style", 35, FontStyle.Strikeout, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.DarkGreen, new Point(0, 0));
            picboxcaptcha.Image = image;
        }
        private void picboxcaptcha_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (txtcaptcha.Text == number.ToString() && checkBox1.Checked)
            {
                SignInform s = new SignInform();
                MessageBox.Show("Your account information is Completed");
                s.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Does not match text with Captcha.");
            }
        }

        private void panelrobot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

        }
    }
}

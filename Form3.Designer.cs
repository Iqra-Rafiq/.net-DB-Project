
namespace Projectfinal
{
    partial class SignUpCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpCustomer));
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxsignup = new System.Windows.Forms.PictureBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.lblprovince = new System.Windows.Forms.Label();
            this.rdnfemale = new System.Windows.Forms.RadioButton();
            this.rdnmale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblage = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpswrd = new System.Windows.Forms.Label();
            this.lblSignup = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxsignup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(526, 136);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(161, 26);
            this.txtname.TabIndex = 33;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(378, 140);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 21);
            this.lblname.TabIndex = 32;
            this.lblname.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picboxsignup);
            this.panel1.Location = new System.Drawing.Point(-5, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 597);
            this.panel1.TabIndex = 31;
            // 
            // picboxsignup
            // 
            this.picboxsignup.Image = ((System.Drawing.Image)(resources.GetObject("picboxsignup.Image")));
            this.picboxsignup.Location = new System.Drawing.Point(35, 176);
            this.picboxsignup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picboxsignup.Name = "picboxsignup";
            this.picboxsignup.Size = new System.Drawing.Size(168, 185);
            this.picboxsignup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxsignup.TabIndex = 7;
            this.picboxsignup.TabStop = false;
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Green;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.Location = new System.Drawing.Point(704, 462);
            this.btnnext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(74, 28);
            this.btnnext.TabIndex = 30;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblprovince
            // 
            this.lblprovince.AutoSize = true;
            this.lblprovince.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprovince.Location = new System.Drawing.Point(378, 417);
            this.lblprovince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprovince.Name = "lblprovince";
            this.lblprovince.Size = new System.Drawing.Size(37, 21);
            this.lblprovince.TabIndex = 28;
            this.lblprovince.Text = "City";
            // 
            // rdnfemale
            // 
            this.rdnfemale.AutoSize = true;
            this.rdnfemale.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnfemale.Location = new System.Drawing.Point(616, 366);
            this.rdnfemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnfemale.Name = "rdnfemale";
            this.rdnfemale.Size = new System.Drawing.Size(69, 22);
            this.rdnfemale.TabIndex = 27;
            this.rdnfemale.TabStop = true;
            this.rdnfemale.Text = "Female";
            this.rdnfemale.UseVisualStyleBackColor = true;
            // 
            // rdnmale
            // 
            this.rdnmale.AutoSize = true;
            this.rdnmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnmale.Location = new System.Drawing.Point(526, 366);
            this.rdnmale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdnmale.Name = "rdnmale";
            this.rdnmale.Size = new System.Drawing.Size(56, 21);
            this.rdnmale.TabIndex = 26;
            this.rdnmale.TabStop = true;
            this.rdnmale.Text = "Male";
            this.rdnmale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(378, 366);
            this.lblgender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 25;
            this.lblgender.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(526, 309);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1998, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 28);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(1998, 12, 1, 0, 0, 0, 0);
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(378, 314);
            this.lblage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(37, 21);
            this.lblage.TabIndex = 23;
            this.lblage.Text = "Age";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(378, 262);
            this.lblnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(116, 21);
            this.lblnumber.TabIndex = 22;
            this.lblnumber.Text = "Phone Number";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.Location = new System.Drawing.Point(526, 258);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(161, 26);
            this.txtphonenumber.TabIndex = 21;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(526, 214);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(161, 26);
            this.txtemail.TabIndex = 20;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(378, 219);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(108, 21);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "Email Address";
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(526, 171);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(161, 28);
            this.txtpwd.TabIndex = 36;
            // 
            // lblusername
            // 
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(700, 31);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(8, 25);
            this.lblusername.TabIndex = 34;
            this.lblusername.Text = "Username";
            // 
            // lblpswrd
            // 
            this.lblpswrd.AutoSize = true;
            this.lblpswrd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpswrd.Location = new System.Drawing.Point(378, 179);
            this.lblpswrd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpswrd.Name = "lblpswrd";
            this.lblpswrd.Size = new System.Drawing.Size(77, 21);
            this.lblpswrd.TabIndex = 37;
            this.lblpswrd.Text = "Password";
            // 
            // lblSignup
            // 
            this.lblSignup.BackColor = System.Drawing.Color.Green;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSignup.Location = new System.Drawing.Point(434, 7);
            this.lblSignup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(283, 56);
            this.lblSignup.TabIndex = 38;
            this.lblSignup.Text = "Sign Up";
            this.lblSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(524, 412);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 26);
            this.textBox1.TabIndex = 39;
            // 
            // SignUpCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 592);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSignup);
            this.Controls.Add(this.lblpswrd);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblprovince);
            this.Controls.Add(this.rdnfemale);
            this.Controls.Add(this.rdnmale);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignUpCustomer";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxsignup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblprovince;
        private System.Windows.Forms.RadioButton rdnfemale;
        private System.Windows.Forms.RadioButton rdnmale;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpswrd;
        private System.Windows.Forms.PictureBox picboxsignup;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.TextBox textBox1;
    }
}
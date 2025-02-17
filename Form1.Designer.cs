
namespace Projectfinal
{
    partial class SignInform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInform));
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblline = new System.Windows.Forms.Label();
            this.btnewaccount = new System.Windows.Forms.Button();
            this.picboxgreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxgreen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(568, 262);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(377, 33);
            this.txtusername.TabIndex = 11;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(568, 379);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(377, 30);
            this.txtpassword.TabIndex = 12;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(563, 214);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(108, 27);
            this.lblusername.TabIndex = 13;
            this.lblusername.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Green;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(568, 455);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(377, 40);
            this.btnlogin.TabIndex = 15;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblline
            // 
            this.lblline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblline.Location = new System.Drawing.Point(578, 535);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(367, 5);
            this.lblline.TabIndex = 16;
            // 
            // btnewaccount
            // 
            this.btnewaccount.AutoEllipsis = true;
            this.btnewaccount.BackColor = System.Drawing.Color.Transparent;
            this.btnewaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnewaccount.ForeColor = System.Drawing.Color.Green;
            this.btnewaccount.Location = new System.Drawing.Point(599, 584);
            this.btnewaccount.Name = "btnewaccount";
            this.btnewaccount.Size = new System.Drawing.Size(310, 59);
            this.btnewaccount.TabIndex = 17;
            this.btnewaccount.Text = "Create New Account";
            this.btnewaccount.UseVisualStyleBackColor = false;
            this.btnewaccount.Click += new System.EventHandler(this.btnewaccount_Click);
            // 
            // picboxgreen
            // 
            this.picboxgreen.Image = ((System.Drawing.Image)(resources.GetObject("picboxgreen.Image")));
            this.picboxgreen.Location = new System.Drawing.Point(605, -26);
            this.picboxgreen.Name = "picboxgreen";
            this.picboxgreen.Size = new System.Drawing.Size(304, 193);
            this.picboxgreen.TabIndex = 19;
            this.picboxgreen.TabStop = false;
            // 
            // SignInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 729);
            this.Controls.Add(this.picboxgreen);
            this.Controls.Add(this.btnewaccount);
            this.Controls.Add(this.lblline);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignInform";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxgreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Button btnewaccount;
        private System.Windows.Forms.PictureBox picboxgreen;
    }
}


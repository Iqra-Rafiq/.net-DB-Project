
namespace Projectfinal
{
    partial class CaptchaCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaCustomer));
            this.panelrobot = new System.Windows.Forms.Panel();
            this.picboxrobot = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxpanel = new System.Windows.Forms.PictureBox();
            this.btnverify = new System.Windows.Forms.Button();
            this.txtcaptcha = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.picboxcaptcha = new System.Windows.Forms.PictureBox();
            this.panelrobot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrobot)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxpanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // panelrobot
            // 
            this.panelrobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelrobot.Controls.Add(this.picboxrobot);
            this.panelrobot.Controls.Add(this.checkBox1);
            this.panelrobot.Location = new System.Drawing.Point(602, 374);
            this.panelrobot.Name = "panelrobot";
            this.panelrobot.Size = new System.Drawing.Size(299, 100);
            this.panelrobot.TabIndex = 13;
            this.panelrobot.Paint += new System.Windows.Forms.PaintEventHandler(this.panelrobot_Paint);
            // 
            // picboxrobot
            // 
            this.picboxrobot.Image = ((System.Drawing.Image)(resources.GetObject("picboxrobot.Image")));
            this.picboxrobot.Location = new System.Drawing.Point(159, 14);
            this.picboxrobot.Name = "picboxrobot";
            this.picboxrobot.Size = new System.Drawing.Size(112, 70);
            this.picboxrobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxrobot.TabIndex = 7;
            this.picboxrobot.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(13, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 28);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "I\'m not robot.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.picboxpanel);
            this.panel1.Location = new System.Drawing.Point(-16, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 730);
            this.panel1.TabIndex = 12;
            // 
            // picboxpanel
            // 
            this.picboxpanel.Image = ((System.Drawing.Image)(resources.GetObject("picboxpanel.Image")));
            this.picboxpanel.Location = new System.Drawing.Point(68, 258);
            this.picboxpanel.Name = "picboxpanel";
            this.picboxpanel.Size = new System.Drawing.Size(152, 151);
            this.picboxpanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxpanel.TabIndex = 0;
            this.picboxpanel.TabStop = false;
            // 
            // btnverify
            // 
            this.btnverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.Location = new System.Drawing.Point(937, 517);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(111, 41);
            this.btnverify.TabIndex = 11;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = true;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // txtcaptcha
            // 
            this.txtcaptcha.Location = new System.Drawing.Point(602, 277);
            this.txtcaptcha.Name = "txtcaptcha";
            this.txtcaptcha.Size = new System.Drawing.Size(224, 22);
            this.txtcaptcha.TabIndex = 10;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(955, 259);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(114, 40);
            this.btnrefresh.TabIndex = 9;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // picboxcaptcha
            // 
            this.picboxcaptcha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picboxcaptcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picboxcaptcha.Location = new System.Drawing.Point(488, 158);
            this.picboxcaptcha.Name = "picboxcaptcha";
            this.picboxcaptcha.Size = new System.Drawing.Size(179, 93);
            this.picboxcaptcha.TabIndex = 8;
            this.picboxcaptcha.TabStop = false;
            this.picboxcaptcha.Click += new System.EventHandler(this.picboxcaptcha_Click);
            // 
            // CaptchaCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 729);
            this.Controls.Add(this.panelrobot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.txtcaptcha);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.picboxcaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CaptchaCustomer";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panelrobot.ResumeLayout(false);
            this.panelrobot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrobot)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxpanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelrobot;
        private System.Windows.Forms.PictureBox picboxrobot;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxpanel;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.TextBox txtcaptcha;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.PictureBox picboxcaptcha;
    }
}
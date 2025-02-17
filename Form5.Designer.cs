
namespace Projectfinal
{
    partial class AdminMenuform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnviewcustomers = new System.Windows.Forms.Button();
            this.btnsoldproducts = new System.Windows.Forms.Button();
            this.btnviewproducts = new System.Windows.Forms.Button();
            this.btnaddsellers = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnviewcustomers);
            this.panel1.Controls.Add(this.btnsoldproducts);
            this.panel1.Controls.Add(this.btnviewproducts);
            this.panel1.Controls.Add(this.btnaddsellers);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 288);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnviewcustomers
            // 
            this.btnviewcustomers.BackColor = System.Drawing.Color.Green;
            this.btnviewcustomers.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewcustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnviewcustomers.Image")));
            this.btnviewcustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewcustomers.Location = new System.Drawing.Point(410, 12);
            this.btnviewcustomers.Name = "btnviewcustomers";
            this.btnviewcustomers.Size = new System.Drawing.Size(208, 78);
            this.btnviewcustomers.TabIndex = 3;
            this.btnviewcustomers.Text = "Customers";
            this.btnviewcustomers.UseVisualStyleBackColor = false;
            this.btnviewcustomers.Click += new System.EventHandler(this.btnviewcustomers_Click);
            // 
            // btnsoldproducts
            // 
            this.btnsoldproducts.BackColor = System.Drawing.Color.Green;
            this.btnsoldproducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoldproducts.Image = ((System.Drawing.Image)(resources.GetObject("btnsoldproducts.Image")));
            this.btnsoldproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsoldproducts.Location = new System.Drawing.Point(410, 112);
            this.btnsoldproducts.Name = "btnsoldproducts";
            this.btnsoldproducts.Size = new System.Drawing.Size(214, 78);
            this.btnsoldproducts.TabIndex = 2;
            this.btnsoldproducts.Text = "            Sold Products";
            this.btnsoldproducts.UseVisualStyleBackColor = false;
            this.btnsoldproducts.Click += new System.EventHandler(this.btnsoldproducts_Click);
            // 
            // btnviewproducts
            // 
            this.btnviewproducts.BackColor = System.Drawing.Color.Green;
            this.btnviewproducts.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewproducts.Image = ((System.Drawing.Image)(resources.GetObject("btnviewproducts.Image")));
            this.btnviewproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnviewproducts.Location = new System.Drawing.Point(624, 12);
            this.btnviewproducts.Name = "btnviewproducts";
            this.btnviewproducts.Size = new System.Drawing.Size(239, 78);
            this.btnviewproducts.TabIndex = 1;
            this.btnviewproducts.Text = "Products";
            this.btnviewproducts.UseVisualStyleBackColor = false;
            this.btnviewproducts.Click += new System.EventHandler(this.btnviewproducts_Click);
            // 
            // btnaddsellers
            // 
            this.btnaddsellers.BackColor = System.Drawing.Color.Green;
            this.btnaddsellers.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsellers.Image = ((System.Drawing.Image)(resources.GetObject("btnaddsellers.Image")));
            this.btnaddsellers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddsellers.Location = new System.Drawing.Point(181, 12);
            this.btnaddsellers.Name = "btnaddsellers";
            this.btnaddsellers.Size = new System.Drawing.Size(217, 78);
            this.btnaddsellers.TabIndex = 0;
            this.btnaddsellers.Text = "        Add Sellers";
            this.btnaddsellers.UseVisualStyleBackColor = false;
            this.btnaddsellers.Click += new System.EventHandler(this.btnaddsellers_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.homeToolStripMenuItem.Text = "Users";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Green;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(181, 112);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 78);
            this.button6.TabIndex = 8;
            this.button6.Text = "        View Riders";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AdminMenuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1011, 592);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMenuform";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnviewcustomers;
        private System.Windows.Forms.Button btnsoldproducts;
        private System.Windows.Forms.Button btnviewproducts;
        private System.Windows.Forms.Button btnaddsellers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button6;
    }
}
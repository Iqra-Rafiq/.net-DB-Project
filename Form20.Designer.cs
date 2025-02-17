
namespace Projectfinal
{
    partial class Billform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billform));
            this.lblbill = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbill
            // 
            this.lblbill.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbill.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblbill.ImageKey = "(none)";
            this.lblbill.Location = new System.Drawing.Point(12, 72);
            this.lblbill.Name = "lblbill";
            this.lblbill.Size = new System.Drawing.Size(100, 43);
            this.lblbill.TabIndex = 0;
            this.lblbill.Text = "Bill : ";
            this.lblbill.Click += new System.EventHandler(this.lblbill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.Green;
            this.lbltotalprice.ImageKey = "(none)";
            this.lbltotalprice.Location = new System.Drawing.Point(85, 72);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(138, 43);
            this.lbltotalprice.TabIndex = 2;
            this.lbltotalprice.Click += new System.EventHandler(this.lbltotalprice_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(33, 279);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(125, 56);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Billform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 400);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblbill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Billform";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblbill;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Button btnback;
    }
}
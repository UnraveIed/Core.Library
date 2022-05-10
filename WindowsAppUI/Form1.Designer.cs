
namespace WindowsAppUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btbManager = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbManager
            // 
            this.btbManager.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btbManager.Image = ((System.Drawing.Image)(resources.GetObject("btbManager.Image")));
            this.btbManager.Location = new System.Drawing.Point(50, 12);
            this.btbManager.Name = "btbManager";
            this.btbManager.Size = new System.Drawing.Size(112, 103);
            this.btbManager.TabIndex = 0;
            this.btbManager.Text = "Admin Girişi";
            this.btbManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btbManager.UseVisualStyleBackColor = false;
            this.btbManager.Click += new System.EventHandler(this.btbManager_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.Info;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(245, 12);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(106, 103);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Müşteri Girişi";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.Khaki;
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.Location = new System.Drawing.Point(147, 134);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(112, 103);
            this.btnNewCustomer.TabIndex = 2;
            this.btnNewCustomer.Text = "Üye Ol";
            this.btnNewCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 267);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btbManager);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbManager;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
    }
}



namespace WindowsAppUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCategoryCrudForm = new System.Windows.Forms.Button();
            this.btnCustomerCrudForm = new System.Windows.Forms.Button();
            this.btnLibraryCrudForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnCategoryCrudForm);
            this.groupBox1.Controls.Add(this.btnCustomerCrudForm);
            this.groupBox1.Controls.Add(this.btnLibraryCrudForm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 379);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Islemler";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Khaki;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(11, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(268, 62);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Çıkış";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCategoryCrudForm
            // 
            this.btnCategoryCrudForm.BackColor = System.Drawing.Color.Khaki;
            this.btnCategoryCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryCrudForm.Image")));
            this.btnCategoryCrudForm.Location = new System.Drawing.Point(11, 39);
            this.btnCategoryCrudForm.Name = "btnCategoryCrudForm";
            this.btnCategoryCrudForm.Size = new System.Drawing.Size(268, 62);
            this.btnCategoryCrudForm.TabIndex = 1;
            this.btnCategoryCrudForm.Text = "Kitaplarım";
            this.btnCategoryCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoryCrudForm.UseVisualStyleBackColor = false;
            this.btnCategoryCrudForm.Click += new System.EventHandler(this.btnCategoryCrudForm_Click);
            // 
            // btnCustomerCrudForm
            // 
            this.btnCustomerCrudForm.BackColor = System.Drawing.Color.Khaki;
            this.btnCustomerCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerCrudForm.Image")));
            this.btnCustomerCrudForm.Location = new System.Drawing.Point(11, 209);
            this.btnCustomerCrudForm.Name = "btnCustomerCrudForm";
            this.btnCustomerCrudForm.Size = new System.Drawing.Size(268, 62);
            this.btnCustomerCrudForm.TabIndex = 3;
            this.btnCustomerCrudForm.Text = "Bilgilerimi Guncelle";
            this.btnCustomerCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerCrudForm.UseVisualStyleBackColor = false;
            this.btnCustomerCrudForm.Click += new System.EventHandler(this.btnCustomerCrudForm_Click);
            // 
            // btnLibraryCrudForm
            // 
            this.btnLibraryCrudForm.BackColor = System.Drawing.Color.Khaki;
            this.btnLibraryCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryCrudForm.Image")));
            this.btnLibraryCrudForm.Location = new System.Drawing.Point(11, 121);
            this.btnLibraryCrudForm.Name = "btnLibraryCrudForm";
            this.btnLibraryCrudForm.Size = new System.Drawing.Size(268, 62);
            this.btnLibraryCrudForm.TabIndex = 2;
            this.btnLibraryCrudForm.Text = "Kitap Kirala";
            this.btnLibraryCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibraryCrudForm.UseVisualStyleBackColor = false;
            this.btnLibraryCrudForm.Click += new System.EventHandler(this.btnLibraryCrudForm_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(335, 410);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCategoryCrudForm;
        private System.Windows.Forms.Button btnCustomerCrudForm;
        private System.Windows.Forms.Button btnLibraryCrudForm;
    }
}
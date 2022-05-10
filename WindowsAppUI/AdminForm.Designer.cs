
namespace WindowsAppUI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCategoryCrudForm = new System.Windows.Forms.Button();
            this.btnBookCrudForm = new System.Windows.Forms.Button();
            this.btnCustomerCrudForm = new System.Windows.Forms.Button();
            this.btnLibraryCrudForm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnCategoryCrudForm);
            this.groupBox1.Controls.Add(this.btnBookCrudForm);
            this.groupBox1.Controls.Add(this.btnCustomerCrudForm);
            this.groupBox1.Controls.Add(this.btnLibraryCrudForm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin İşlemleri";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(11, 300);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 62);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCategoryCrudForm
            // 
            this.btnCategoryCrudForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoryCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryCrudForm.Image")));
            this.btnCategoryCrudForm.Location = new System.Drawing.Point(11, 96);
            this.btnCategoryCrudForm.Name = "btnCategoryCrudForm";
            this.btnCategoryCrudForm.Size = new System.Drawing.Size(183, 62);
            this.btnCategoryCrudForm.TabIndex = 1;
            this.btnCategoryCrudForm.Text = "Kategori İşlemleri";
            this.btnCategoryCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoryCrudForm.UseVisualStyleBackColor = false;
            this.btnCategoryCrudForm.Click += new System.EventHandler(this.btnCategoryCrudForm_Click);
            // 
            // btnBookCrudForm
            // 
            this.btnBookCrudForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnBookCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBookCrudForm.Image")));
            this.btnBookCrudForm.Location = new System.Drawing.Point(11, 28);
            this.btnBookCrudForm.Name = "btnBookCrudForm";
            this.btnBookCrudForm.Size = new System.Drawing.Size(183, 62);
            this.btnBookCrudForm.TabIndex = 0;
            this.btnBookCrudForm.Text = "Kitap İşlemleri";
            this.btnBookCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookCrudForm.UseVisualStyleBackColor = false;
            this.btnBookCrudForm.Click += new System.EventHandler(this.btnBookCrudForm_Click);
            // 
            // btnCustomerCrudForm
            // 
            this.btnCustomerCrudForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnCustomerCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerCrudForm.Image")));
            this.btnCustomerCrudForm.Location = new System.Drawing.Point(11, 232);
            this.btnCustomerCrudForm.Name = "btnCustomerCrudForm";
            this.btnCustomerCrudForm.Size = new System.Drawing.Size(183, 62);
            this.btnCustomerCrudForm.TabIndex = 3;
            this.btnCustomerCrudForm.Text = "Kullanıcı Sil";
            this.btnCustomerCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerCrudForm.UseVisualStyleBackColor = false;
            this.btnCustomerCrudForm.Click += new System.EventHandler(this.btnCustomerCrudForm_Click);
            // 
            // btnLibraryCrudForm
            // 
            this.btnLibraryCrudForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibraryCrudForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryCrudForm.Image")));
            this.btnLibraryCrudForm.Location = new System.Drawing.Point(11, 164);
            this.btnLibraryCrudForm.Name = "btnLibraryCrudForm";
            this.btnLibraryCrudForm.Size = new System.Drawing.Size(183, 62);
            this.btnLibraryCrudForm.TabIndex = 2;
            this.btnLibraryCrudForm.Text = "Kütüphane İşlemleri";
            this.btnLibraryCrudForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibraryCrudForm.UseVisualStyleBackColor = false;
            this.btnLibraryCrudForm.Click += new System.EventHandler(this.btnLibraryCrudForm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(564, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCategoryCrudForm;
        private System.Windows.Forms.Button btnBookCrudForm;
        private System.Windows.Forms.Button btnCustomerCrudForm;
        private System.Windows.Forms.Button btnLibraryCrudForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
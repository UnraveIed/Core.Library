
namespace WindowsAppUI
{
    partial class BookCrudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookCrudForm));
            this.dgwCrud = new System.Windows.Forms.DataGridView();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxBookId = new System.Windows.Forms.TextBox();
            this.nmrStock = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxLibrary = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUsersForm = new System.Windows.Forms.Button();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.btnLibrariesForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCrud)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStock)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCrud
            // 
            this.dgwCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCrud.Location = new System.Drawing.Point(3, 19);
            this.dgwCrud.Name = "dgwCrud";
            this.dgwCrud.RowTemplate.Height = 25;
            this.dgwCrud.Size = new System.Drawing.Size(831, 292);
            this.dgwCrud.TabIndex = 0;
            this.dgwCrud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCrud_CellClick);
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(151, 59);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(172, 23);
            this.tbxBookName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategorisi  :";
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.Location = new System.Drawing.Point(151, 177);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.Size = new System.Drawing.Size(172, 23);
            this.tbxPublisher.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yayınevi :";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(151, 147);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(172, 23);
            this.tbxAuthor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yazar Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.tbxBookId);
            this.groupBox1.Controls.Add(this.nmrStock);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbxLibrary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbxBookName);
            this.groupBox1.Controls.Add(this.tbxPublisher);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxAuthor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 470);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Detayları";
            // 
            // tbxBookId
            // 
            this.tbxBookId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbxBookId.Location = new System.Drawing.Point(151, 30);
            this.tbxBookId.Name = "tbxBookId";
            this.tbxBookId.ReadOnly = true;
            this.tbxBookId.Size = new System.Drawing.Size(172, 23);
            this.tbxBookId.TabIndex = 21;
            // 
            // nmrStock
            // 
            this.nmrStock.Location = new System.Drawing.Point(151, 212);
            this.nmrStock.Name = "nmrStock";
            this.nmrStock.Size = new System.Drawing.Size(171, 23);
            this.nmrStock.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kitap Id :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.btnBookAdd);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Location = new System.Drawing.Point(8, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 142);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnBookAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBookAdd.Image")));
            this.btnBookAdd.Location = new System.Drawing.Point(6, 22);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(99, 106);
            this.btnBookAdd.TabIndex = 13;
            this.btnBookAdd.Text = "Ekle";
            this.btnBookAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookAdd.UseVisualStyleBackColor = false;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(216, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 106);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(111, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 106);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxLibrary
            // 
            this.cbxLibrary.FormattingEnabled = true;
            this.cbxLibrary.Location = new System.Drawing.Point(151, 118);
            this.cbxLibrary.Name = "cbxLibrary";
            this.cbxLibrary.Size = new System.Drawing.Size(172, 23);
            this.cbxLibrary.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kütüphanesi  :";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(151, 89);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(172, 23);
            this.cbxCategory.TabIndex = 17;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stok Adedi :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(1072, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PlaceholderText = "Kitap Ismi";
            this.tbxSearch.Size = new System.Drawing.Size(124, 23);
            this.tbxSearch.TabIndex = 15;
            this.tbxSearch.Tag = "";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(680, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 74);
            this.btnBack.TabIndex = 17;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(990, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Arama :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwCrud);
            this.groupBox2.Location = new System.Drawing.Point(362, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 314);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.btnUsersForm);
            this.groupBox4.Controls.Add(this.btnCategoriesForm);
            this.groupBox4.Controls.Add(this.btnLibrariesForm);
            this.groupBox4.Controls.Add(this.btnBack);
            this.groupBox4.Location = new System.Drawing.Point(365, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(834, 94);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sayfalar";
            // 
            // btnUsersForm
            // 
            this.btnUsersForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnUsersForm.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersForm.Image")));
            this.btnUsersForm.Location = new System.Drawing.Point(490, 14);
            this.btnUsersForm.Name = "btnUsersForm";
            this.btnUsersForm.Size = new System.Drawing.Size(89, 74);
            this.btnUsersForm.TabIndex = 20;
            this.btnUsersForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsersForm.UseVisualStyleBackColor = false;
            this.btnUsersForm.Click += new System.EventHandler(this.btnUsersForm_Click);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoriesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriesForm.Image")));
            this.btnCategoriesForm.Location = new System.Drawing.Point(291, 14);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(89, 74);
            this.btnCategoriesForm.TabIndex = 19;
            this.btnCategoriesForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoriesForm.UseVisualStyleBackColor = false;
            this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click);
            // 
            // btnLibrariesForm
            // 
            this.btnLibrariesForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibrariesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrariesForm.Image")));
            this.btnLibrariesForm.Location = new System.Drawing.Point(91, 14);
            this.btnLibrariesForm.Name = "btnLibrariesForm";
            this.btnLibrariesForm.Size = new System.Drawing.Size(89, 74);
            this.btnLibrariesForm.TabIndex = 18;
            this.btnLibrariesForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibrariesForm.UseVisualStyleBackColor = false;
            this.btnLibrariesForm.Click += new System.EventHandler(this.btnLibrariesForm_Click);
            // 
            // BookCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookCrudForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.BookCrudForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCrud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStock)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCrud;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxLibrary;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUsersForm;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.Button btnLibrariesForm;
        private System.Windows.Forms.NumericUpDown nmrStock;
        private System.Windows.Forms.TextBox tbxBookId;
        private System.Windows.Forms.Label label8;
    }
}

namespace WindowsAppUI
{
    partial class LibraryCrudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryCrudForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxLibraryId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLibraryAdd = new System.Windows.Forms.Button();
            this.btnLibraryUpdate = new System.Windows.Forms.Button();
            this.btnLibraryDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.tbxLibraryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgwLibraryCrud = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnUsersForm = new System.Windows.Forms.Button();
            this.btnBooksForm = new System.Windows.Forms.Button();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibraryCrud)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxLibraryId);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxAvailable);
            this.groupBox1.Controls.Add(this.tbxLibraryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 280);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Detayları";
            // 
            // tbxLibraryId
            // 
            this.tbxLibraryId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbxLibraryId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxLibraryId.Location = new System.Drawing.Point(113, 48);
            this.tbxLibraryId.Name = "tbxLibraryId";
            this.tbxLibraryId.ReadOnly = true;
            this.tbxLibraryId.Size = new System.Drawing.Size(161, 23);
            this.tbxLibraryId.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLibraryAdd);
            this.groupBox2.Controls.Add(this.btnLibraryUpdate);
            this.groupBox2.Controls.Add(this.btnLibraryDelete);
            this.groupBox2.Location = new System.Drawing.Point(8, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 141);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnLibraryAdd
            // 
            this.btnLibraryAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibraryAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryAdd.Image")));
            this.btnLibraryAdd.Location = new System.Drawing.Point(6, 37);
            this.btnLibraryAdd.Name = "btnLibraryAdd";
            this.btnLibraryAdd.Size = new System.Drawing.Size(81, 95);
            this.btnLibraryAdd.TabIndex = 13;
            this.btnLibraryAdd.Text = "Ekle";
            this.btnLibraryAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibraryAdd.UseVisualStyleBackColor = false;
            this.btnLibraryAdd.Click += new System.EventHandler(this.btnLibraryAdd_Click);
            // 
            // btnLibraryUpdate
            // 
            this.btnLibraryUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibraryUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryUpdate.Image")));
            this.btnLibraryUpdate.Location = new System.Drawing.Point(93, 37);
            this.btnLibraryUpdate.Name = "btnLibraryUpdate";
            this.btnLibraryUpdate.Size = new System.Drawing.Size(81, 95);
            this.btnLibraryUpdate.TabIndex = 16;
            this.btnLibraryUpdate.Text = "Güncelle";
            this.btnLibraryUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibraryUpdate.UseVisualStyleBackColor = false;
            this.btnLibraryUpdate.Click += new System.EventHandler(this.btnLibraryUpdate_Click);
            // 
            // btnLibraryDelete
            // 
            this.btnLibraryDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibraryDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnLibraryDelete.Image")));
            this.btnLibraryDelete.Location = new System.Drawing.Point(179, 37);
            this.btnLibraryDelete.Name = "btnLibraryDelete";
            this.btnLibraryDelete.Size = new System.Drawing.Size(81, 95);
            this.btnLibraryDelete.TabIndex = 20;
            this.btnLibraryDelete.Text = "Sil";
            this.btnLibraryDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibraryDelete.UseVisualStyleBackColor = false;
            this.btnLibraryDelete.Click += new System.EventHandler(this.btnLibraryDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Kütüphane Id :";
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Location = new System.Drawing.Point(211, 108);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(63, 19);
            this.cbxAvailable.TabIndex = 25;
            this.cbxAvailable.Text = "Durum";
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // tbxLibraryName
            // 
            this.tbxLibraryName.Location = new System.Drawing.Point(113, 79);
            this.tbxLibraryName.Name = "tbxLibraryName";
            this.tbxLibraryName.Size = new System.Drawing.Size(161, 23);
            this.tbxLibraryName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kütüphane Adı :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(348, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 53);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgwLibraryCrud
            // 
            this.dgwLibraryCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLibraryCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLibraryCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLibraryCrud.Location = new System.Drawing.Point(3, 19);
            this.dgwLibraryCrud.Name = "dgwLibraryCrud";
            this.dgwLibraryCrud.RowTemplate.Height = 25;
            this.dgwLibraryCrud.Size = new System.Drawing.Size(442, 142);
            this.dgwLibraryCrud.TabIndex = 25;
            this.dgwLibraryCrud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLibraryCrud_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgwLibraryCrud);
            this.groupBox3.Location = new System.Drawing.Point(324, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 164);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Arama :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(647, 37);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(125, 23);
            this.tbxSearch.TabIndex = 28;
            // 
            // btnUsersForm
            // 
            this.btnUsersForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnUsersForm.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersForm.Image")));
            this.btnUsersForm.Location = new System.Drawing.Point(245, 25);
            this.btnUsersForm.Name = "btnUsersForm";
            this.btnUsersForm.Size = new System.Drawing.Size(80, 53);
            this.btnUsersForm.TabIndex = 31;
            this.btnUsersForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsersForm.UseVisualStyleBackColor = false;
            // 
            // btnBooksForm
            // 
            this.btnBooksForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnBooksForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBooksForm.Image")));
            this.btnBooksForm.Location = new System.Drawing.Point(26, 25);
            this.btnBooksForm.Name = "btnBooksForm";
            this.btnBooksForm.Size = new System.Drawing.Size(80, 53);
            this.btnBooksForm.TabIndex = 30;
            this.btnBooksForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBooksForm.UseVisualStyleBackColor = false;
            this.btnBooksForm.Click += new System.EventHandler(this.btnBooksForm_Click);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoriesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriesForm.Image")));
            this.btnCategoriesForm.Location = new System.Drawing.Point(136, 25);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(80, 53);
            this.btnCategoriesForm.TabIndex = 29;
            this.btnCategoriesForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoriesForm.UseVisualStyleBackColor = false;
            this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBooksForm);
            this.groupBox4.Controls.Add(this.btnUsersForm);
            this.groupBox4.Controls.Add(this.btnCategoriesForm);
            this.groupBox4.Controls.Add(this.btnBack);
            this.groupBox4.Location = new System.Drawing.Point(324, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(448, 84);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sayfalar";
            // 
            // LibraryCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 345);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibraryCrudForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane İşlemleri";
            this.Load += new System.EventHandler(this.LibraryCrudForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLibraryCrud)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnLibraryAdd;
        private System.Windows.Forms.TextBox tbxLibraryName;
        private System.Windows.Forms.Button btnLibraryDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwLibraryCrud;
        private System.Windows.Forms.CheckBox cbxAvailable;
        private System.Windows.Forms.Button btnLibraryUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnUsersForm;
        private System.Windows.Forms.Button btnBooksForm;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxLibraryId;
        private System.Windows.Forms.Label label3;
    }
}

namespace WindowsAppUI
{
    partial class CategoryCrudForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryCrudForm));
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCategoryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwCategoryCrud = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUsersForm = new System.Windows.Forms.Button();
            this.btnBooksForm = new System.Windows.Forms.Button();
            this.btnLibrariesForm = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategoryCrud)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(426, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 53);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(699, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Arama :";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(753, 34);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(124, 23);
            this.tbxSearch.TabIndex = 21;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoryDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryDelete.Image")));
            this.btnCategoryDelete.Location = new System.Drawing.Point(204, 28);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(93, 102);
            this.btnCategoryDelete.TabIndex = 20;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoryDelete.UseVisualStyleBackColor = false;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCategoryId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbxCategoryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 301);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // tbxCategoryId
            // 
            this.tbxCategoryId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbxCategoryId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxCategoryId.Location = new System.Drawing.Point(115, 48);
            this.tbxCategoryId.Name = "tbxCategoryId";
            this.tbxCategoryId.ReadOnly = true;
            this.tbxCategoryId.Size = new System.Drawing.Size(172, 23);
            this.tbxCategoryId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori Id :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCategoryUpdate);
            this.groupBox3.Controls.Add(this.btnCategoryDelete);
            this.groupBox3.Controls.Add(this.btnCategoryAdd);
            this.groupBox3.Location = new System.Drawing.Point(10, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoryUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryUpdate.Image")));
            this.btnCategoryUpdate.Location = new System.Drawing.Point(105, 28);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(93, 102);
            this.btnCategoryUpdate.TabIndex = 16;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoryUpdate.UseVisualStyleBackColor = false;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoryAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoryAdd.Image")));
            this.btnCategoryAdd.Location = new System.Drawing.Point(6, 28);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(93, 102);
            this.btnCategoryAdd.TabIndex = 13;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoryAdd.UseVisualStyleBackColor = false;
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Location = new System.Drawing.Point(115, 79);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(172, 23);
            this.tbxCategoryName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Adı :";
            // 
            // dgwCategoryCrud
            // 
            this.dgwCategoryCrud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCategoryCrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategoryCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwCategoryCrud.Location = new System.Drawing.Point(3, 19);
            this.dgwCategoryCrud.Name = "dgwCategoryCrud";
            this.dgwCategoryCrud.RowTemplate.Height = 25;
            this.dgwCategoryCrud.Size = new System.Drawing.Size(512, 151);
            this.dgwCategoryCrud.TabIndex = 23;
            this.dgwCategoryCrud.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategoryCrud_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgwCategoryCrud);
            this.groupBox2.Location = new System.Drawing.Point(359, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 173);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // btnUsersForm
            // 
            this.btnUsersForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnUsersForm.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersForm.Image")));
            this.btnUsersForm.Location = new System.Drawing.Point(285, 25);
            this.btnUsersForm.Name = "btnUsersForm";
            this.btnUsersForm.Size = new System.Drawing.Size(80, 53);
            this.btnUsersForm.TabIndex = 27;
            this.btnUsersForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsersForm.UseVisualStyleBackColor = false;
            // 
            // btnBooksForm
            // 
            this.btnBooksForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnBooksForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBooksForm.Image")));
            this.btnBooksForm.Location = new System.Drawing.Point(6, 25);
            this.btnBooksForm.Name = "btnBooksForm";
            this.btnBooksForm.Size = new System.Drawing.Size(80, 53);
            this.btnBooksForm.TabIndex = 26;
            this.btnBooksForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBooksForm.UseVisualStyleBackColor = false;
            this.btnBooksForm.Click += new System.EventHandler(this.btnBooksForm_Click);
            // 
            // btnLibrariesForm
            // 
            this.btnLibrariesForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibrariesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrariesForm.Image")));
            this.btnLibrariesForm.Location = new System.Drawing.Point(142, 25);
            this.btnLibrariesForm.Name = "btnLibrariesForm";
            this.btnLibrariesForm.Size = new System.Drawing.Size(80, 53);
            this.btnLibrariesForm.TabIndex = 25;
            this.btnLibrariesForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibrariesForm.UseVisualStyleBackColor = false;
            this.btnLibrariesForm.Click += new System.EventHandler(this.btnLibrariesForm_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUsersForm);
            this.groupBox4.Controls.Add(this.btnBooksForm);
            this.groupBox4.Controls.Add(this.btnLibrariesForm);
            this.groupBox4.Controls.Add(this.btnBack);
            this.groupBox4.Location = new System.Drawing.Point(362, 237);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(512, 93);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sayfalar";
            // 
            // CategoryCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 378);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryCrudForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori İşlemleri";
            this.Load += new System.EventHandler(this.CategoryCrudForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategoryCrud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwCategoryCrud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUsersForm;
        private System.Windows.Forms.Button btnBooksForm;
        private System.Windows.Forms.Button btnLibrariesForm;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxCategoryId;
        private System.Windows.Forms.Label label3;
    }
}
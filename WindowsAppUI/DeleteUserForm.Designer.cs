
namespace WindowsAppUI
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCategoriesForm = new System.Windows.Forms.Button();
            this.btnBooksForm = new System.Windows.Forms.Button();
            this.btnLibrariesForm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.txtCustomerEmail);
            this.groupBox1.Controls.Add(this.txtCustomerSurname);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtUserId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustomerId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Detayları ";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUser.Image")));
            this.btnDeleteUser.Location = new System.Drawing.Point(113, 213);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(81, 55);
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.Text = "Sil";
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(146, 155);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(165, 23);
            this.txtCustomerEmail.TabIndex = 9;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(146, 126);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.ReadOnly = true;
            this.txtCustomerSurname.Size = new System.Drawing.Size(165, 23);
            this.txtCustomerSurname.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(146, 97);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(165, 23);
            this.txtCustomerName.TabIndex = 7;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(146, 68);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(165, 23);
            this.txtUserId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Müşteri Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müşteri Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Müşteri Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Id :";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(146, 39);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(165, 23);
            this.txtCustomerId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(721, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(805, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 23);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(338, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(632, 128);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnCategoriesForm
            // 
            this.btnCategoriesForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnCategoriesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriesForm.Image")));
            this.btnCategoriesForm.Location = new System.Drawing.Point(194, 22);
            this.btnCategoriesForm.Name = "btnCategoriesForm";
            this.btnCategoriesForm.Size = new System.Drawing.Size(80, 53);
            this.btnCategoriesForm.TabIndex = 31;
            this.btnCategoriesForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCategoriesForm.UseVisualStyleBackColor = false;
            this.btnCategoriesForm.Click += new System.EventHandler(this.btnCategoriesForm_Click);
            // 
            // btnBooksForm
            // 
            this.btnBooksForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnBooksForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBooksForm.Image")));
            this.btnBooksForm.Location = new System.Drawing.Point(21, 22);
            this.btnBooksForm.Name = "btnBooksForm";
            this.btnBooksForm.Size = new System.Drawing.Size(80, 53);
            this.btnBooksForm.TabIndex = 30;
            this.btnBooksForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBooksForm.UseVisualStyleBackColor = false;
            this.btnBooksForm.Click += new System.EventHandler(this.btnBooksForm_Click);
            // 
            // btnLibrariesForm
            // 
            this.btnLibrariesForm.BackColor = System.Drawing.SystemColors.Info;
            this.btnLibrariesForm.Image = ((System.Drawing.Image)(resources.GetObject("btnLibrariesForm.Image")));
            this.btnLibrariesForm.Location = new System.Drawing.Point(345, 22);
            this.btnLibrariesForm.Name = "btnLibrariesForm";
            this.btnLibrariesForm.Size = new System.Drawing.Size(80, 53);
            this.btnLibrariesForm.TabIndex = 29;
            this.btnLibrariesForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLibrariesForm.UseVisualStyleBackColor = false;
            this.btnLibrariesForm.Click += new System.EventHandler(this.btnLibrariesForm_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(497, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 53);
            this.btnBack.TabIndex = 28;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCategoriesForm);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.btnBooksForm);
            this.groupBox3.Controls.Add(this.btnLibrariesForm);
            this.groupBox3.Location = new System.Drawing.Point(338, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 94);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sayfalar";
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 330);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.DeleteUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCategoriesForm;
        private System.Windows.Forms.Button btnBooksForm;
        private System.Windows.Forms.Button btnLibrariesForm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
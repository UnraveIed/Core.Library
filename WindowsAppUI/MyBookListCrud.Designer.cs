
namespace WindowsAppUI
{
    partial class MyBookListCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBookListCrud));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxSearchBookName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearBooks = new System.Windows.Forms.Button();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMyBookAdd = new System.Windows.Forms.Button();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.tbxLibraryName = new System.Windows.Forms.TextBox();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.tbxAuthorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgwMyBooks = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnClearMyBook = new System.Windows.Forms.Button();
            this.tbxUserId = new System.Windows.Forms.TextBox();
            this.tbxDeliveryTime = new System.Windows.Forms.TextBox();
            this.tbxDateOfUpload = new System.Windows.Forms.TextBox();
            this.tbxBookId = new System.Windows.Forms.TextBox();
            this.tbxListId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyBooks)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.cbxCategoryName);
            this.groupBox5.Controls.Add(this.tbxSearchBookName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(102, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(737, 70);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Arama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Azalan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Artan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kategori";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(543, 41);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoryName.TabIndex = 12;
            this.cbxCategoryName.Text = "Default";
            this.cbxCategoryName.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryName_SelectedIndexChanged);
            this.cbxCategoryName.SelectedValueChanged += new System.EventHandler(this.cbxCategoryName_SelectedValueChanged);
            this.cbxCategoryName.EnabledChanged += new System.EventHandler(this.cbxCategoryName_EnabledChanged);
            // 
            // tbxSearchBookName
            // 
            this.tbxSearchBookName.Location = new System.Drawing.Point(69, 42);
            this.tbxSearchBookName.Name = "tbxSearchBookName";
            this.tbxSearchBookName.Size = new System.Drawing.Size(100, 23);
            this.tbxSearchBookName.TabIndex = 10;
            this.tbxSearchBookName.TextChanged += new System.EventHandler(this.tbxSearchBookName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Stok Adetine Göre Sırala";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kitap Adı ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgwData);
            this.groupBox4.Location = new System.Drawing.Point(6, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(956, 256);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alınabilir Kitap Listesi";
            // 
            // dgwData
            // 
            this.dgwData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwData.Location = new System.Drawing.Point(3, 19);
            this.dgwData.Name = "dgwData";
            this.dgwData.RowTemplate.Height = 25;
            this.dgwData.Size = new System.Drawing.Size(950, 234);
            this.dgwData.TabIndex = 0;
            this.dgwData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwData_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Khaki;
            this.groupBox3.Controls.Add(this.btnClearBooks);
            this.groupBox3.Controls.Add(this.tbxStock);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnMyBookAdd);
            this.groupBox3.Controls.Add(this.tbxPublisher);
            this.groupBox3.Controls.Add(this.tbxLibraryName);
            this.groupBox3.Controls.Add(this.tbxCategoryName);
            this.groupBox3.Controls.Add(this.tbxBookName);
            this.groupBox3.Controls.Add(this.tbxAuthorName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 351);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kitap Bilgileri";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnClearBooks
            // 
            this.btnClearBooks.BackColor = System.Drawing.SystemColors.Info;
            this.btnClearBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnClearBooks.Image")));
            this.btnClearBooks.Location = new System.Drawing.Point(230, 13);
            this.btnClearBooks.Name = "btnClearBooks";
            this.btnClearBooks.Size = new System.Drawing.Size(33, 34);
            this.btnClearBooks.TabIndex = 15;
            this.btnClearBooks.UseVisualStyleBackColor = false;
            this.btnClearBooks.Click += new System.EventHandler(this.btnClearBooks_Click);
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(140, 221);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.ReadOnly = true;
            this.tbxStock.Size = new System.Drawing.Size(100, 23);
            this.tbxStock.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stok :";
            // 
            // btnMyBookAdd
            // 
            this.btnMyBookAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnMyBookAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnMyBookAdd.Image")));
            this.btnMyBookAdd.Location = new System.Drawing.Point(44, 267);
            this.btnMyBookAdd.Name = "btnMyBookAdd";
            this.btnMyBookAdd.Size = new System.Drawing.Size(175, 66);
            this.btnMyBookAdd.TabIndex = 2;
            this.btnMyBookAdd.Text = "Kitapligima Ekle";
            this.btnMyBookAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyBookAdd.UseVisualStyleBackColor = false;
            this.btnMyBookAdd.Click += new System.EventHandler(this.btnMyBookAdd_Click);
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.Location = new System.Drawing.Point(140, 125);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.ReadOnly = true;
            this.tbxPublisher.Size = new System.Drawing.Size(100, 23);
            this.tbxPublisher.TabIndex = 8;
            // 
            // tbxLibraryName
            // 
            this.tbxLibraryName.Location = new System.Drawing.Point(140, 188);
            this.tbxLibraryName.Name = "tbxLibraryName";
            this.tbxLibraryName.ReadOnly = true;
            this.tbxLibraryName.Size = new System.Drawing.Size(100, 23);
            this.tbxLibraryName.TabIndex = 12;
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Location = new System.Drawing.Point(140, 156);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.ReadOnly = true;
            this.tbxCategoryName.Size = new System.Drawing.Size(100, 23);
            this.tbxCategoryName.TabIndex = 11;
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(140, 63);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.ReadOnly = true;
            this.tbxBookName.Size = new System.Drawing.Size(100, 23);
            this.tbxBookName.TabIndex = 6;
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Location = new System.Drawing.Point(140, 95);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.ReadOnly = true;
            this.tbxAuthorName.Size = new System.Drawing.Size(100, 23);
            this.tbxAuthorName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kütüphane Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yazar Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kategorisi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yayınevi :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Location = new System.Drawing.Point(287, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgwMyBooks);
            this.groupBox6.Location = new System.Drawing.Point(6, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(956, 331);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Kitaplarim";
            // 
            // dgwMyBooks
            // 
            this.dgwMyBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMyBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMyBooks.Location = new System.Drawing.Point(3, 19);
            this.dgwMyBooks.Name = "dgwMyBooks";
            this.dgwMyBooks.RowTemplate.Height = 25;
            this.dgwMyBooks.Size = new System.Drawing.Size(950, 309);
            this.dgwMyBooks.TabIndex = 0;
            this.dgwMyBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMyBooks_CellClick);
            this.dgwMyBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMyBooks_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Info;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(44, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 66);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Geri";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.BackColor = System.Drawing.SystemColors.Info;
            this.btnDeliver.Image = ((System.Drawing.Image)(resources.GetObject("btnDeliver.Image")));
            this.btnDeliver.Location = new System.Drawing.Point(44, 215);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(175, 66);
            this.btnDeliver.TabIndex = 3;
            this.btnDeliver.Text = "Iade Et";
            this.btnDeliver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeliver.UseVisualStyleBackColor = false;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Khaki;
            this.groupBox8.Controls.Add(this.btnClearMyBook);
            this.groupBox8.Controls.Add(this.btnBack);
            this.groupBox8.Controls.Add(this.tbxUserId);
            this.groupBox8.Controls.Add(this.tbxDeliveryTime);
            this.groupBox8.Controls.Add(this.tbxDateOfUpload);
            this.groupBox8.Controls.Add(this.tbxBookId);
            this.groupBox8.Controls.Add(this.btnDeliver);
            this.groupBox8.Controls.Add(this.tbxListId);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Location = new System.Drawing.Point(12, 369);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(269, 359);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "İade Bilgileri";
            // 
            // btnClearMyBook
            // 
            this.btnClearMyBook.BackColor = System.Drawing.SystemColors.Info;
            this.btnClearMyBook.Image = ((System.Drawing.Image)(resources.GetObject("btnClearMyBook.Image")));
            this.btnClearMyBook.Location = new System.Drawing.Point(230, 10);
            this.btnClearMyBook.Name = "btnClearMyBook";
            this.btnClearMyBook.Size = new System.Drawing.Size(33, 34);
            this.btnClearMyBook.TabIndex = 16;
            this.btnClearMyBook.UseVisualStyleBackColor = false;
            this.btnClearMyBook.Click += new System.EventHandler(this.btnClearMyBook_Click);
            // 
            // tbxUserId
            // 
            this.tbxUserId.Location = new System.Drawing.Point(140, 89);
            this.tbxUserId.Name = "tbxUserId";
            this.tbxUserId.ReadOnly = true;
            this.tbxUserId.Size = new System.Drawing.Size(100, 23);
            this.tbxUserId.TabIndex = 15;
            // 
            // tbxDeliveryTime
            // 
            this.tbxDeliveryTime.Location = new System.Drawing.Point(140, 176);
            this.tbxDeliveryTime.Name = "tbxDeliveryTime";
            this.tbxDeliveryTime.ReadOnly = true;
            this.tbxDeliveryTime.Size = new System.Drawing.Size(100, 23);
            this.tbxDeliveryTime.TabIndex = 13;
            // 
            // tbxDateOfUpload
            // 
            this.tbxDateOfUpload.Location = new System.Drawing.Point(140, 147);
            this.tbxDateOfUpload.Name = "tbxDateOfUpload";
            this.tbxDateOfUpload.ReadOnly = true;
            this.tbxDateOfUpload.Size = new System.Drawing.Size(100, 23);
            this.tbxDateOfUpload.TabIndex = 12;
            // 
            // tbxBookId
            // 
            this.tbxBookId.Location = new System.Drawing.Point(140, 60);
            this.tbxBookId.Name = "tbxBookId";
            this.tbxBookId.ReadOnly = true;
            this.tbxBookId.Size = new System.Drawing.Size(100, 23);
            this.tbxBookId.TabIndex = 11;
            // 
            // tbxListId
            // 
            this.tbxListId.Location = new System.Drawing.Point(140, 118);
            this.tbxListId.Name = "tbxListId";
            this.tbxListId.ReadOnly = true;
            this.tbxListId.Size = new System.Drawing.Size(100, 23);
            this.tbxListId.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 179);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "En Geç İade Tarihi :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 15);
            this.label18.TabIndex = 7;
            this.label18.Text = "Eklenme Tarihi :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 15);
            this.label17.TabIndex = 6;
            this.label17.Text = "Kitap Id :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "List Id :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "UserId :";
            // 
            // MyBookListCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1267, 735);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyBookListCrud";
            this.Text = "Kitap Kirala";
            this.Load += new System.EventHandler(this.MyBookListCrud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMyBooks)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btnMyBookAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgwMyBooks;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox me;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sher;
        private System.Windows.Forms.TextBox tbxLibraryName;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbxSearchBookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxUserId;
        private System.Windows.Forms.TextBox tbxDeliveryTime;
        private System.Windows.Forms.TextBox tbxDateOfUpload;
        private System.Windows.Forms.TextBox tbxBookId;
        private System.Windows.Forms.TextBox tbxListId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox bx;
        private System.Windows.Forms.Button btnClearBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearMyBook;
        private System.Windows.Forms.Button button2;
    }
}
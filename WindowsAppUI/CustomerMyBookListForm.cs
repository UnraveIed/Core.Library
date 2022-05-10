using Business.Abstracts;
using Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsAppUI
{
    public partial class CustomerMyBookListForm : Form
    {
        public CustomerMyBookListForm()
        {
            InitializeComponent();
            _myBookListService = InstanceFactory.GetInstance<IMyBookListService>();
        }
        public int id;
        private IMyBookListService _myBookListService;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxListId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbxBookName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxBookId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxCategoryName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxLibraryName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbxAuthor.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbxPublisher.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbxDateOfUpload.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbxDeliveredTime.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnAddBookList_Click(object sender, EventArgs e)
        {
            MyBookListCrud myBookListCrud = new MyBookListCrud();
            myBookListCrud.id = id;
            myBookListCrud.Show();
            this.Close();
        }

        private void btnUsersForm_Click(object sender, EventArgs e)
        {
            CustomerUpdateForm customerUpdate = new CustomerUpdateForm();
            customerUpdate.id = id;
            customerUpdate.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.id = id;
            customerForm.Show();
            this.Close();
        }

        private void CustomerMyBookListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _myBookListService.GetAllByUserId(id).Data;
        }
    }
}

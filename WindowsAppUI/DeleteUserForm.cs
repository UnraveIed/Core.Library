using Business.Abstracts;
using Business.DependencyResolvers.Ninject;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WindowsAppUI
{
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private ICustomerService _customerService;

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var result = _customerService.Update(new Customer
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                UserId = int.Parse(txtUserId.Text),
                Name = txtCustomerName.Text,
                Surname = txtCustomerSurname.Text,
                Email = txtCustomerEmail.Text,
                IsActive = false
            });
            LoadCustomers();
            MessageBox.Show(result.Message);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUserId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCustomerName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCustomerSurname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCustomerEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dataGridView1.DataSource = _customerService.GetAll().Data;
        }

        private void btnBooksForm_Click(object sender, EventArgs e)
        {
            BookCrudForm bookCrud = new BookCrudForm();
            bookCrud.Show();
            this.Close();
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            CategoryCrudForm categoryCrud = new CategoryCrudForm();
            categoryCrud.Show();
            this.Close();
        }

        private void btnLibrariesForm_Click(object sender, EventArgs e)
        {
            LibraryCrudForm libraryCrud = new LibraryCrudForm();
            libraryCrud.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
    }
}

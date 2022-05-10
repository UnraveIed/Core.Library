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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        private ICustomerService _customerService;

        private void btnBookCrudForm_Click(object sender, EventArgs e)
        {
            BookCrudForm book = new BookCrudForm();
            book.Show();
            this.Hide();
        }

        private void btnCategoryCrudForm_Click(object sender, EventArgs e)
        {
            CategoryCrudForm category = new CategoryCrudForm();
            category.Show();
            this.Hide();
        }

        private void btnLibraryCrudForm_Click(object sender, EventArgs e)
        {
            LibraryCrudForm library = new LibraryCrudForm();
            library.Show();
            this.Hide();
        }

        private void btnCustomerCrudForm_Click(object sender, EventArgs e)
        {
            DeleteUserForm deleteUser = new DeleteUserForm();
            deleteUser.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _customerService.GetAll().Data;
        }

    }
}

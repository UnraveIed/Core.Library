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
    public partial class LibraryCrudForm : Form
    {
        public LibraryCrudForm()
        {
            InitializeComponent();
            _libraryService = InstanceFactory.GetInstance<ILibraryService>();
        }

        private ILibraryService _libraryService;

        private void dgwLibraryCrud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxLibraryId.Text = dgwLibraryCrud.CurrentRow.Cells[0].Value.ToString();
            tbxLibraryName.Text = dgwLibraryCrud.CurrentRow.Cells[1].Value.ToString();
            cbxAvailable.Checked = Convert.ToBoolean(dgwLibraryCrud.CurrentRow.Cells[2].Value);
        }

        private void LoadLibraries()
        {
            dgwLibraryCrud.DataSource = _libraryService.GetAll().Data;
        }

        private void LibraryCrudForm_Load(object sender, EventArgs e)
        {
            LoadLibraries();
        }

        private void btnLibraryAdd_Click(object sender, EventArgs e)
        {
            var add = _libraryService.Add(new Library
            {
                LibraryName = tbxLibraryName.Text,
                IsAvailable = Convert.ToBoolean(cbxAvailable.Checked)
            });
            LoadLibraries();
            MessageBox.Show(add.Message);
        }

        private void btnLibraryUpdate_Click(object sender, EventArgs e)
        {
            var add = _libraryService.Update(new Library
            {
                LibraryId = Convert.ToInt32(dgwLibraryCrud.CurrentRow.Cells[0].Value),
                LibraryName = tbxLibraryName.Text,
                IsAvailable = Convert.ToBoolean(cbxAvailable.Checked)
            });
            LoadLibraries();
            MessageBox.Show(add.Message);
        }

        private void btnLibraryDelete_Click(object sender, EventArgs e)
        {
            var add = _libraryService.Delete(new Library
            {
                LibraryId = Convert.ToInt32(dgwLibraryCrud.CurrentRow.Cells[0].Value)
            });
            LoadLibraries();
            MessageBox.Show(add.Message);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void btnBooksForm_Click(object sender, EventArgs e)
        {
            BookCrudForm bookCrudForm = new BookCrudForm();
            bookCrudForm.Show();
            this.Hide();
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            CategoryCrudForm categoryCrudForm = new CategoryCrudForm();
            categoryCrudForm.Show();
            this.Hide();
        }
    }
}

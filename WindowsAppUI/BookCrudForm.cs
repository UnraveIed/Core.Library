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
    public partial class BookCrudForm : Form
    {
        public BookCrudForm()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _libraryService = InstanceFactory.GetInstance<ILibraryService>();
        }

        private ILibraryService _libraryService;
        private ICategoryService _categoryService;
        private IBookService _bookService;
        

        private void BookCrudForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadCategories();
            LoadLibraries();
        }
        private void LoadBooks()
        {
            dgwCrud.DataSource = _bookService.GetAll().Data;
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll().Data;
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";           
        }

        private void LoadLibraries()
        {
            cbxLibrary.DataSource = _libraryService.GetAll().Data;
            cbxLibrary.DisplayMember = "LibraryName";
            cbxLibrary.ValueMember = "LibraryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //dgwCrud.DataSource = _bookService.GetByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue)).Data;
            }
            catch
            {

            }
        }

        private void dgwCrud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBookId.Text = dgwCrud.CurrentRow.Cells[0].Value.ToString();
            tbxBookName.Text = dgwCrud.CurrentRow.Cells[3].Value.ToString();
            cbxCategory.SelectedValue = dgwCrud.CurrentRow.Cells[2].Value;
            cbxLibrary.SelectedValue = dgwCrud.CurrentRow.Cells[1].Value;
            tbxAuthor.Text = dgwCrud.CurrentRow.Cells[4].Value.ToString();
            tbxPublisher.Text = dgwCrud.CurrentRow.Cells[6].Value.ToString();
            nmrStock.Value = int.Parse(dgwCrud.CurrentRow.Cells[5].Value.ToString());

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            var add =_bookService.Add(new Book
            {
                CategoryId = Convert.ToInt32(cbxCategory.SelectedValue),
                LibraryId = Convert.ToInt32(cbxLibrary.SelectedValue),
                BookName = tbxBookName.Text,
                AuthorName = tbxAuthor.Text,
                Stock = Convert.ToInt16(nmrStock.Value),
                Publisher = tbxPublisher.Text
            });
            LoadBooks();
            MessageBox.Show(add.Message);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var add = _bookService.Update(new Book
            {
                BookId = int.Parse(dgwCrud.CurrentRow.Cells[0].Value.ToString().Trim()),
                LibraryId = int.Parse(cbxLibrary.SelectedValue.ToString()),
                CategoryId = int.Parse(cbxCategory.SelectedValue.ToString().Trim()),             
                BookName = tbxBookName.Text,
                AuthorName = tbxAuthor.Text,
                Stock = Convert.ToInt16(nmrStock.Value),
                Publisher = tbxPublisher.Text
            });
            LoadBooks();
            MessageBox.Show(add.Message);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var add = _bookService.Delete(new Book
            {
                BookId = Convert.ToInt32(dgwCrud.CurrentRow.Cells[0].Value)  
            });
            LoadBooks();
            MessageBox.Show(add.Message);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwCrud.DataSource = _bookService.GetByBookName(tbxSearch.Text).Data;
            }
            else
            {
                LoadBooks();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void btnLibrariesForm_Click(object sender, EventArgs e)
        {
            LibraryCrudForm library = new LibraryCrudForm();
            library.Show();
            this.Hide();
        }

        private void btnCategoriesForm_Click(object sender, EventArgs e)
        {
            CategoryCrudForm category = new CategoryCrudForm();
            category.Show();
            this.Hide();
        }

        private void btnUsersForm_Click(object sender, EventArgs e)
        {

        }
    }
}

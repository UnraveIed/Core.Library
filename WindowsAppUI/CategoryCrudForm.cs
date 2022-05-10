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
    public partial class CategoryCrudForm : Form
    {
        public CategoryCrudForm()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private ICategoryService _categoryService;

        

        private void LoadCategories()
        {
            dgwCategoryCrud.DataSource = _categoryService.GetAll().Data;
        }

        private void CategoryCrudForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void dgwCategoryCrud_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCategoryId.Text = dgwCategoryCrud.CurrentRow.Cells[0].Value.ToString();
            tbxCategoryName.Text = dgwCategoryCrud.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            var add = _categoryService.Add(new Category
            {       
                CategoryName = tbxCategoryName.Text,               
            });
            LoadCategories();
            MessageBox.Show(add.Message);
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            var add = _categoryService.Update(new Category
            {
                CategoryId = Convert.ToInt32(dgwCategoryCrud.CurrentRow.Cells[0].Value),
                CategoryName = tbxCategoryName.Text
            });
            LoadCategories();
            MessageBox.Show(add.Message);
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            var add = _categoryService.Delete(new Category
            {
                CategoryId = Convert.ToInt32(dgwCategoryCrud.CurrentRow.Cells[0].Value)
            });
            LoadCategories();
            MessageBox.Show(add.Message);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwCategoryCrud.DataSource = _categoryService.GetByCategoryName(tbxSearch.Text).Data;
            }
            else
            {
                LoadCategories();
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

        private void btnBooksForm_Click(object sender, EventArgs e)
        {
            BookCrudForm bookCrudForm = new BookCrudForm();
            bookCrudForm.Show();
            this.Hide();
        }

      
    }
}

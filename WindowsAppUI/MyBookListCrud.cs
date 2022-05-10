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
    public partial class MyBookListCrud : Form
    {
        public MyBookListCrud()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _myBookListService = InstanceFactory.GetInstance<IMyBookListService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _libraryService = InstanceFactory.GetInstance<ILibraryService>();
        }

        private IMyBookListService _myBookListService;
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private ILibraryService _libraryService;

        DateTime date = DateTime.Now;
        public int id;
        private void MyBookListCrud_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadMyBooks();
            LoadCategories();
            LoadLibraries();
        }

        private void LoadBooks()
        {
            dgwData.DataSource = _bookService.GetBookDetails().Data;
        }

        private void LoadMyBooks()
        {
            dgwMyBooks.DataSource = _myBookListService.GetAllByUserId(id).Data;
        }

        private void dgwData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBookName.Text = dgwData.CurrentRow.Cells[1].Value.ToString();
            tbxLibraryName.Text = dgwData.CurrentRow.Cells[6].Value.ToString();
            tbxCategoryName.Text = dgwData.CurrentRow.Cells[5].Value.ToString();
            tbxAuthorName.Text = dgwData.CurrentRow.Cells[2].Value.ToString();
            tbxPublisher.Text = dgwData.CurrentRow.Cells[3].Value.ToString();
            tbxStock.Text = dgwData.CurrentRow.Cells[4].Value.ToString();
        }
        private void dgwMyBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUserId.Text = dgwMyBooks.CurrentRow.Cells[9].Value.ToString();
            tbxListId.Text = dgwMyBooks.CurrentRow.Cells[0].Value.ToString();
            tbxBookId.Text = dgwMyBooks.CurrentRow.Cells[1].Value.ToString();
            tbxDeliveryTime.Text = dgwMyBooks.CurrentRow.Cells[8].Value.ToString();
            tbxDateOfUpload.Text = dgwMyBooks.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnMyBookAdd_Click(object sender, EventArgs e)
        {
            var add = _myBookListService.Add(new MyBookList
            {
                UserId = Convert.ToInt32(id),
                BookId = Convert.ToInt32(dgwData.CurrentRow.Cells[0].Value),
                DateOfUpload = date,
                DeliveryTime = date.AddMonths(1),
                IsDelivered = false
            });
            ClearBookDetails();
            LoadMyBooks();
            LoadBooks();
            MessageBox.Show(add.Message);
        }

        private void DeleteMyList()
        {
            var add = _myBookListService.Delete(new MyBookList
            {
                ListId = Convert.ToInt32(dgwMyBooks.CurrentRow.Cells[0].Value)
            });
            ClearMyBookDetails();
            LoadMyBooks();
            LoadBooks();
            MessageBox.Show(add.Message);
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            DeleteMyList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.id = id;
            customerForm.Show();
            this.Close();
        }

        private void LoadCategories()
        {
            
            cbxCategoryName.DataSource = _categoryService.GetAll().Data;
            cbxCategoryName.DisplayMember = "CategoryName";
            cbxCategoryName.ValueMember = "CategoryId";
        }

        private void LoadLibraries()
        {
            //cbxLibraryName.DataSource = _libraryService.GetAll().Data;
            //cbxLibraryName.DisplayMember = "LibraryName";
            //cbxLibraryName.ValueMember = "LibraryId";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnClearBooks_Click(object sender, EventArgs e)
        {
            ClearBookDetails();
        }

        private void btnClearMyBook_Click(object sender, EventArgs e)
        {
            ClearMyBookDetails();
        }
        private void ClearBookDetails()
        {
            tbxBookName.Clear();
            tbxLibraryName.Clear();
            tbxCategoryName.Clear();
            tbxAuthorName.Clear();
            tbxPublisher.Clear();
            tbxStock.Clear();
            LoadBooks();
        }
        private void ClearMyBookDetails()
        {
            tbxUserId.Clear();
            tbxListId.Clear();
            tbxBookId.Clear();
            tbxDeliveryTime.Clear();
            tbxDateOfUpload.Clear();
        }

        private void dgwMyBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxSearchBookName_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearchBookName.Text==null || tbxSearchBookName.Text=="" || tbxSearchBookName.Text==" ")
            {
                LoadBooks();
            }
            else
            {
                dgwData.DataSource = _bookService.SearchBookName(tbxSearchBookName.Text).Data;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgwData.DataSource = _bookService.OrderByStockDesc().Data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwData.DataSource = _bookService.OrderByStockAsc().Data;
        }

        private void cbxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            //Category selectedCar = (Category)cbxCategoryName.SelectedItem;

            //dgwData.DataSource = _bookService.BookSearchByCategory(selectedCar.CategoryName).Data;
        }

        private void cbxCategoryName_SelectedValueChanged(object sender, EventArgs e)
        {
            //Category selectedCar = (Category)cbxCategoryName.SelectedItem;
            //if (selectedCar.CategoryName=="")
            //{

            //}
            //else
            //{
            //    dgwData.DataSource = _bookService.BookSearchByCategory(selectedCar.CategoryName).Data;
            //}
            
        }

        private void cbxCategoryName_EnabledChanged(object sender, EventArgs e)
        {
            var selectedItem = (ComboBox)sender;
            dgwData.DataSource = _bookService.BookSearchByCategory(selectedItem.ValueMember).Data;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

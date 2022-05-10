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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

        }

        public int id;
        

        private void btnCustomerCrudForm_Click(object sender, EventArgs e)
        {
            CustomerUpdateForm customerUpdate = new CustomerUpdateForm();
            customerUpdate.id = id;
            customerUpdate.Show();
            
            this.Hide();
        }


        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLibraryCrudForm_Click(object sender, EventArgs e)
        {
            MyBookListCrud myBookList = new MyBookListCrud();
            myBookList.id = id;
            myBookList.Show();
            this.Hide();
        }

        private void btnCategoryCrudForm_Click(object sender, EventArgs e)
        {
            CustomerMyBookListForm customerMyBookList = new CustomerMyBookListForm();
            customerMyBookList.id = id;
            customerMyBookList.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

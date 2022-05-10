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
    public partial class CustomerUpdateForm : Form
    {
        public CustomerUpdateForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
            
        }

        private ICustomerService _customerService;
        public int id;
        private Customer customer;
        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {   
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            customer = _customerService.GetByUserId(id).Data;
            tbxCustomerName.Text = customer.Name;
            tbxCustomerSurname.Text = customer.Surname;
            tbxCustomerEmail.Text = customer.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _customerService.Update(new Customer
            {
                CustomerId = customer.CustomerId,
                IsActive = true,
                Name = tbxCustomerName.Text,
                Surname = tbxCustomerSurname.Text,
                Email = tbxCustomerEmail.Text,
                UserId = id
            });
            MessageBox.Show(result.Message);
            CustomerForm customerForm = new CustomerForm();
            customerForm.id = id;
            customerForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.id = id;
            customerForm.Show();
            this.Close();
        }
    }
}

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
    public partial class LoginCustomerForm : Form
    {
        public LoginCustomerForm()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }

        public int id;
        private IUserService _userService;
        private ICustomerService _customerService;

        private void btnLogin_Click(object sender, EventArgs e)
        {       
            CustomerForm customerForm = new CustomerForm();
            if (tbxLoginUserName.Text != "" && tbxLoginPassword.Text != "")
            {
                var result = _userService.checkLogin(tbxLoginUserName.Text, tbxLoginPassword.Text);
                if (result.Success)
                {
                    var user = _userService.GetByUserName(tbxLoginUserName.Text).Data;
                    var active = _customerService.GetByLoginUserId(user.UserId).Data;
                    if (active != null)
                    {
                        id = _customerService.GetByLoginUserId(user.UserId).Data.UserId;
                        customerForm.id = id;
                        customerForm.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bloke edilmiş hesap");
                    }
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
            else
            {
                MessageBox.Show("Lutfen bos alan birakmayiniz.");
            }            
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomer = new NewCustomerForm();
            newCustomer.ShowDialog();
            this.Close();
        }

        private void LoginCustomerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

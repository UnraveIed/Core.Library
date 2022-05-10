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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _customerService = InstanceFactory.GetInstance<ICustomerService>();
        }
        private IUserService _userService;
        private ICustomerService _customerService;
        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text != "" && tbxUserName.Text != "")
            {
                var user = _userService.GetByUserName(tbxUserName.Text).Data;
                var user1 = _userService.GetByPassword(tbxPassword.Text).Data;
                if (user == null && user1 == null)
                {
                    _userService.Add(new User
                    {
                        UserName = tbxUserName.Text,
                        Password = tbxPassword.Text
                    });

                    var user2  = _userService.GetByUserName(tbxUserName.Text).Data;

                    var result = _customerService.Add(new Customer
                    {
                        UserId = user2.UserId,
                        Name = tbxCustomerName.Text,
                        Surname = tbxCustomerSurname.Text,
                        Email = tbxCustomerEmail.Text,
                        IsActive = true
                    });
                    MessageBox.Show(result.Message);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adında veya şifresinde bir kullanıcı zaten mevcut");
                }         
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi eksiksiz şekilde giriniz.");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}

using Business.Abstracts;
using Business.Concretes;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm newCustomer = new NewCustomerForm();
            newCustomer.Show();
            this.Hide();
        }

        private void btbManager_Click(object sender, EventArgs e)
        {
            LoginAdminForm loginAdmin = new LoginAdminForm();
            loginAdmin.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            LoginCustomerForm loginCustomer = new LoginCustomerForm();
            loginCustomer.Show();
            this.Hide();
        }
    }
}

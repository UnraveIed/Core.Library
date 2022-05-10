using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsAppUI
{
    public partial class LoginAdminForm : Form
    {
        public LoginAdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxLoginPassword.Text == "admin" && tbxLoginUserName.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz");
            }
        }

        private void LoginAdminForm_Load(object sender, EventArgs e)
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

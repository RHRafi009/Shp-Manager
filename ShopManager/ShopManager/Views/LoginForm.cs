using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManager.ApplicationController;
using ShopManager.DataModels;

namespace ShopManager.Views
{
    public partial class LoginForm : Form
    {
        ApplicationBus ab = new ApplicationBus();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User u = new User()
            {
                UserName = this.userNameTextbox.Text,
                Password = this.passwordTextbox.Text
            };
            bool flag = ab.LoginAction(u);
            if (flag)
                this.Hide();
            else
                this.userNamerError.SetError(userNameTextbox, u.ErrorMessage);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ab.Close();
        }
    }
}

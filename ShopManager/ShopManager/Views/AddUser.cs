using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManager.DataModels;
using ShopManager.ApplicationController;

namespace ShopManager.Views
{
    public partial class AddUser : UserControl
    {
        ApplicationBus ab = new ApplicationBus();

        public AddUser()
        {
            InitializeComponent();
        }

        private void adduserButton_Click(object sender, EventArgs e)
        {
            User u = new User() 
            {
                UserName = this.usernameTextbox.Text,
                Password = this.passwordtextbox.Text,
                Role = "Salesman"
            };
            bool flag = ab.AddSalesman(u);
            if(flag)
            {
                this.usernameTextbox.Text = "";
                this.passwordtextbox.Text = "";
                MessageBox.Show($"{u.UserName} has been added");
            }else
            {
                this.errorProvider1.SetError(this.usernameTextbox, u.ErrorMessage);
            }
        }
    }
}

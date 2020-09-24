using ShopManager.ApplicationController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManager.Views
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            UserControl uc = new AddUser();
            uc.Location = new System.Drawing.Point(3, 3);
            uc.Name = "AddUser";
            uc.Size = new System.Drawing.Size(634, 411);
            uc.TabIndex = 0;
            this.contentPanel.Controls.Add(uc);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            this.contentPanel.Controls.Clear();
            UserControl uc = new Reports();
            uc.Location = new System.Drawing.Point(3, 3);
            uc.Name = "sellUI1";
            uc.Size = new System.Drawing.Size(634, 411);
            uc.TabIndex = 0;
            this.contentPanel.Controls.Add(uc);
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new ApplicationBus().Close();
        }
    }
}

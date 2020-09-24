using ShopManager.ApplicationController;
using ShopManager.DataModels;
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
    public partial class SalesForm : Form
    {
        UserControl uc;
        public static User user;


        public SalesForm()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            this.contentpanel.Controls.Clear();
            uc = new AddProductUI();
            this.uc.Location = new System.Drawing.Point(3, 3);
            this.uc.Name = "sellUI1";
            this.uc.Size = new System.Drawing.Size(634, 411);
            this.uc.TabIndex = 0;
            this.contentpanel.Controls.Add(uc);
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            this.contentpanel.Controls.Clear();
            uc = new SellUI();
            this.uc.Location = new System.Drawing.Point(3, 3);
            this.uc.Name = "sellUI1";
            this.uc.Size = new System.Drawing.Size(634, 411);
            this.uc.TabIndex = 0;
            this.contentpanel.Controls.Add(uc);
        }

        private void Restock_Click(object sender, EventArgs e)
        {
            this.contentpanel.Controls.Clear();
            uc = new Restock();
            this.uc.Location = new System.Drawing.Point(3, 3);
            this.uc.Name = "sellUI1";
            this.uc.Size = new System.Drawing.Size(634, 411);
            this.uc.TabIndex = 0;
            this.contentpanel.Controls.Add(uc);
        }

        private void signoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new ApplicationBus().Close();
        }
    }
}

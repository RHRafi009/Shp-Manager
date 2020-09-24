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
    public partial class AddProductUI : UserControl
    {
        SalesController sc = new SalesController();

        public AddProductUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product pp = new Product()
            {
                ProductName = this.productNameTextbox.Text,
                Description = this.deskcriptionText.Text,
                CurrentStock = int.Parse(this.quantityText.Text),
                BuyingCost = Double.Parse(this.buyingCostTextbox.Text),
                Price = Double.Parse(this.pricetextbox.Text),
                RestockDate = DateTime.Now
            };
            bool flag = sc.AddProduct(pp);
            if (flag)
            {
                this.productNameTextbox.Text = "";
                this.deskcriptionText.Text = "";
                this.buyingCostTextbox.Text = "";
                this.productNameTextbox.Text = "";
                this.quantityText.Text = "";
                this.pricetextbox.Text = "";
                MessageBox.Show($"{pp.ProductName} successfully added.");
            }
            else
                MessageBox.Show("An error occured during addimg the product.");
        }
    }
}

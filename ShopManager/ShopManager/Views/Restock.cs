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
    public partial class Restock : UserControl
    {
        List<Product> ppLilst = new List<Product>();
        SalesController sc = new SalesController();
        Product current;

        public Restock()
        {
            InitializeComponent();
            ppLilst = sc.GetAllProducts();
            foreach (Product p in ppLilst)
            {
                this.productCombo.Items.Add($"{p.ProductName} | {p.Id}");
            }
        }

        private void productCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.productCombo.Text.Substring(this.productCombo.Text.IndexOf("|") + 1).Trim());
            foreach (Product p in ppLilst)
            {
                if (p.Id == id)
                {
                    this.current = p;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.current.CurrentStock += int.Parse(this.quantity.Text);
            this.current.BuyingCost = Double.Parse(this.buyingPrice.Text);
            this.current.Price = Double.Parse(this.sellingPrice.Text);
            this.current.RestockDate = DateTime.Now;
            bool flag = sc.UpdateProduct(current);
            if(flag)
            {
                this.productCombo.ResetText();
                this.quantity.Text = "";
                this.buyingPrice.Text = "";
                this.sellingPrice.Text = "";
                MessageBox.Show("Product updated succcesfully");
            }
        }
    }
}

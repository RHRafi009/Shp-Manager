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
    public partial class SellUI : UserControl
    {
        List<Product> ppLilst = new List<Product>();
        List<SaleModel> ssList = new List<SaleModel>();
        BindingList<SaleModel> saleData = new BindingList<SaleModel>();
        SalesController sc = new SalesController();
        Product current;

        public SellUI()
        {
            InitializeComponent();
            this.SetupField();
        }

        private void SetupField()
        {
            ppLilst = sc.GetAllProducts();
            foreach(Product p in ppLilst)
            {
                this.productCombo.Items.Add($"{p.ProductName} | {p.Id}");
            }
            /*saleTable.Columns.Add("Product Name");
            saleTable.Columns.Add("")*/
            this.productData.DataSource = saleData;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.productCombo.Text.Substring(this.productCombo.Text.IndexOf("|") + 1).Trim()); 
            foreach(Product p in ppLilst)
            {
                if(p.Id == id)
                {
                    this.current = p;
                    this.descriptionvalue.Text = p.Description;
                    this.procevalue.Text = p.Price.ToString();
                    this.quantityText.Text = "";
                    this.totalvalue.Text = "";
                }
            }
        }

        private void quantityText_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                double qnty = Double.Parse(this.quantityText.Text);
                this.totalvalue.Text = (current.Price * qnty).ToString();
            }
        }

        private void resetButon_Click(object sender, EventArgs e)
        {
            this.current = null;
            this.descriptionvalue.Text = "";
            this.quantityText.Text = "";
            this.procevalue.Text = "";
            this.totalvalue.Text = "";
            this.productCombo.ResetText();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SaleModel sale = new SaleModel() 
            {
                PrductData = current,
                Salesman = SalesForm.user,
                SalesPrice = Double.Parse(this.totalvalue.Text),
                Profit = (current.Price - current.BuyingCost)*double.Parse(this.quantityText.Text),
                Date = DateTime.Now,
                Quantity = double.Parse(this.quantityText.Text)
            };
            if(sale.Quantity > sale.PrductData.CurrentStock)
            {
                MessageBox.Show("Not enough stock");
                return;
            }else
                ssList.Add(sale);
         /*   this.saleData.Clear();
            this.saleData = new BindingList<SaleModel>(ssList);*/
            /*this.productData.DataSource = saleData;*/
            double total = 0;
            foreach (SaleModel ss in ssList)
                total += ss.SalesPrice;
            this.totalPriceAll.Text = total.ToString();
        }

        private void paidTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.returnvalue.Text = (Double.Parse(this.paidTextbox.Text) - Double.Parse(this.totalPriceAll.Text)).ToString();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool flag = sc.SaveSales(ssList);
            if (flag)
            {
                MessageBox.Show("Saved succesfully");
                this.RefreshAll();
            }
        }

        private void RefreshAll()
        {
            this.SetupField();
            this.current = null;
            this.descriptionvalue.Text = "";
            this.quantityText.Text = "";
            this.procevalue.Text = "";
            this.totalvalue.Text = "";
            this.totalPriceAll.Text = "";
            this.paidTextbox.Text = "";
            this.returnvalue.Text = "";
            this.productCombo.ResetText();
        }

        private void resetAll_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }
    }
}

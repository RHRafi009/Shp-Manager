using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManager.ApplicationController;
using ShopManager.DataModels;

namespace ShopManager.Views
{
    public partial class Reports : UserControl
    {
        SalesController sc = new SalesController();

        public Reports()
        {
            InitializeComponent();
            this.SetupField(DateTime.Now);
        }

        public void SetupField(DateTime dt)
        {
            ReportModel rp = sc.GetReport(dt);
            this.profitvalue.Text = rp.Profit;
            this.totalsale.Text = rp.Total;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.SetupField(this.dateTimePicker1.Value);
        }
    }
}

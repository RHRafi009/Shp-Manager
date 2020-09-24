using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DataModels
{
    public class SaleModel
    {
        public Product PrductData { get; set; }

        public int Id { get; set; }

        public User Salesman { get; set; }

        public Double SalesPrice { get; set; }

        public Double Profit { get; set; }

        public DateTime Date { get; set; }

        public Double Quantity { get; set; }
    }
}

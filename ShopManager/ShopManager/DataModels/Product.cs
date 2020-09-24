using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.DataModels
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public int CurrentStock { get; set; }

        public string Description { get; set; }

        public Double BuyingCost { get; set; }

        public Double Price { get; set; }

        public DateTime RestockDate { get; set; }
    }
}

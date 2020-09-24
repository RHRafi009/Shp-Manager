using ShopManager.Database;
using ShopManager.DataModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.ApplicationController
{
    public class SalesController
    {
        public bool AddProduct(Product pp)
        {
            DbCommunicator dc = new DbCommunicator();
            string query = $"INSERT INTO Products VALUES (" +
                $"'{pp.ProductName}', {pp.CurrentStock}," +
                $"'{pp.Description}', {pp.BuyingCost}," +
                $"{pp.Price}, '{pp.RestockDate}')";
            int row = dc.WriteData(query);
            if (row > 0)
                return true;
            else
                return false;
        }

        public List<Product> GetAllProducts()
        {
            DbCommunicator dc = new DbCommunicator();
            string query = "SELECT * FROM Products";
            SqlDataReader data = dc.GetData(query);
            List<Product> ppList = new List<Product>();
            while(data.Read())
            {
                ppList.Add(new Product()
                {
                    Id = data.GetInt32(0),
                    ProductName = data.GetString(1),
                    CurrentStock = data.GetInt32(2),
                    Description = data.GetString(3),
                    BuyingCost = data.GetDouble(4),
                    Price = data.GetDouble(5)
                });
            }
            dc.DbConnection.Close();
            return ppList;
        }

        public bool SaveSales(List<SaleModel> sales)
        {
            int row = 0;
            foreach(SaleModel ss in sales)
            {
                DbCommunicator dc1 = new DbCommunicator();
                string query = $"INSERT INTO Sales VALUES (" +
                    $"{ss.PrductData.Id}, '{ss.Salesman.UserName}'," +
                    $"{ss.SalesPrice}, {ss.Profit}," +
                    $"'{ss.Date.Date}', {ss.Quantity})";
                row += dc1.WriteData(query);
                dc1.DbConnection.Close();
                DbCommunicator dc2 = new DbCommunicator();
                query = "UPDATE Products SET CurrentStock = " + (ss.PrductData.CurrentStock - ss.Quantity) + " WHERE ID = '" + ss.PrductData.Id + "'";
                row += dc2.WriteData(query);
                dc2.DbConnection.Close();
            }
            if (row > 0)
                return true;
            else
                return false;
        }

        public bool UpdateProduct(Product p)
        {
            DbCommunicator dc = new DbCommunicator();
            string query = $"UPDATE Products SET CurrentStock = {p.CurrentStock}, BuyingCost = {p.BuyingCost}, Price = {p.Price}, RestockDate = '{p.RestockDate}'" +
                $" WHERE Id = {p.Id}";
            int row = dc.WriteData(query);
            dc.DbConnection.Close();
            if (row > 0)
                return true;
            else
                return false;
        }

        public ReportModel GetReport(DateTime dt)
        {
            ReportModel rp = new ReportModel();
            string query = $"SELECT Profit, SalesPrice FROM Sales WHERE Date = '{dt.Date}'";
            DbCommunicator dc = new DbCommunicator();
            SqlDataReader data = dc.GetData(query);
            double profit = 0, total = 0;
            while(data.Read())
            {
                profit += data.GetDouble(0);
                total += data.GetDouble(1);
            }
            dc.DbConnection.Close();
            rp.Profit = profit.ToString();
            rp.Total = total.ToString();
            return rp;
        }
    }
}

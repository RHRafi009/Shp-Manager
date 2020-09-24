using ShopManager.Database;
using ShopManager.DataModels;
using ShopManager.Views;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManager.ApplicationController
{
    public class ApplicationBus
    {
        public bool LoginAction(User u)
        {
            DbCommunicator dc = new DbCommunicator();
            string query = $"SELECT * FROM Users WHERE UserName = '{u.UserName}' AND Password = '{u.Password}'";
            SqlDataReader data = dc.GetData(query);
            while(data.Read())
            {
                u.Role = data.GetString(2);
                if (u.Role.Equals("admin"))
                    new AdminForm().Show();
                else if (u.Role.Equals("Salesman"))
                {
                    SalesForm.user = u;
                    new SalesForm().Show();
                }
                    
                dc.DbConnection.Close();
                return true;
            }
            u.ErrorMessage = "Login credentials do not match";
            return false;
        }

        public bool AddSalesman(User u)
        {
            DbCommunicator dc = new DbCommunicator();
            string query = $"SELECT* FROM Users WHERE UserName = '{u.UserName}'"; 
            SqlDataReader data = dc.GetData(query);
            while(data.Read())
            {
                u.ErrorMessage = "This user is already exist";
                dc.DbConnection.Close();
                return false;
            }
            dc.DbConnection.Close();
            query = $"INSERT INTO Users VALUES ('{u.UserName}','{u.Password}','{u.Role}')";
            int row = dc.WriteData(query);
            dc.DbConnection.Close();
            if (row > 0)
                return true;
            else
                return false;
        }

        public void Close()
        {
            Application.Exit();
        }
    }
}

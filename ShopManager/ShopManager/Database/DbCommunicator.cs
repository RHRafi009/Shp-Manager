using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManager.Database
{
    public class DbCommunicator
    {
        private String dbConnactionString = "Data Source=RAFI\\SQLEXPRESS;Initial Catalog=shopmanagerDB;Integrated Security=True";
        private SqlConnection dbConnection;
        private SqlCommand cmd;

        public DbCommunicator()
        {
            this.DbConnection = new SqlConnection();
            this.DbConnection.ConnectionString = this.dbConnactionString;
        }

        public SqlConnection DbConnection { get => dbConnection; private set => dbConnection = value; }

        public SqlDataReader GetData(String query)
        {
            SqlDataReader data = null;
            try
            {
                this.DbConnection.Open();
                this.cmd = new SqlCommand(query, this.DbConnection);
                data = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                this.ExceptionHandle(ex, query);
            }
            return data;
        }

        public int WriteData(String query)
        {
            int rows = -1;
            try
            {
                this.DbConnection.Open();
                this.cmd = new SqlCommand(query, this.DbConnection);
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                this.ExceptionHandle(ex, query);
            }

            return rows;
        }

        public void ExceptionHandle(Exception ex, String query)
        {
            MessageBox.Show("Error occured when executing sql " + ex.Message.ToString());
        }
    }
}

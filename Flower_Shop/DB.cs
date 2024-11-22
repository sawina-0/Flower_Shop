using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Flower_Shop
{
    internal class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Flower_Shop;Integrated Security=True");
        public void openConnection()
        {
            if (sqlConnection.State==System.Data.ConnectionState.Closed)
            { 
                sqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }
    }
}

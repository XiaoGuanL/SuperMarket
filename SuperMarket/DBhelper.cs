using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket
{
    class DBhelper
    {
        private string connString = @"Data Source =.;Initial Catalog=SurperMarket;User Id=;Pwd=";
        private SqlConnection connection;

        public SqlConnection Connection
        {
            get
            {
                if(connection==null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }
        public void OpenConnection()
        {
            if(connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            else if(connection.State==ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open|| connection.State == ConnectionState.Broken)
            {
                connection.Close();
            }
        }
    }
}
